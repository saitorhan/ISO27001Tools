using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dhcp;
using ISO27001Tools.Entities;

namespace ISO27001Tools.LocalAdminScanning
{
    class Program
    {
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                sqlConnection = new SqlConnection(Properties.Settings.Default.SqlString);
                sqlCommand = new SqlCommand {Connection = sqlConnection};
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception e)
                {
                    // log dosyası
                    return;
                }

                string dhcpServer = Properties.Settings.Default.DhcpServer;
                ScanIpScope(dhcpServer);
                sqlConnection.Close();
            }
        }


        private static void ScanIpScope(string dhcpServerIp)
        {

            DhcpServer dhcpServer = Dhcp.DhcpServer.Connect(dhcpServerIp);
            List<DhcpServerScope> dhcpServerScopes = dhcpServer.Scopes.ToList();



            foreach (DhcpServerScope dhcpServerScope in dhcpServerScopes)
            {
                foreach (DhcpServerClient dhcpServerClient in dhcpServerScope.Clients)
                {
                    ScanIp(dhcpServerClient.IpAddress.ToString(), dhcpServerClient.Name);
                    Console.WriteLine($"{dhcpServerClient.IpAddress} - {dhcpServerClient.Name}");
                }
            }
        }

        private static void ScanIp(string ip, string hostName = "")
        {
            try
            {
                LocalAdmin localAdmin = new LocalAdmin();
                localAdmin.Ip = ip;
                localAdmin.HostName = hostName;

                DirectoryEntry localMachine = new DirectoryEntry("WinNT://" + ip);
            
                DirectoryEntry admGroup = localMachine.Children.Find("administrators","group");
                object members = admGroup.Invoke("members", null);
                foreach (object groupMember in (IEnumerable)members)
                {
                    DirectoryEntry member = new DirectoryEntry(groupMember);
                    localAdmin.AdminAccounts.Add(new Account
                    {
                        Path = member.Path,
                        Name = member.Name,
                        Type = member.SchemaClassName
                    });
                }

                try
                {
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandText =
                        "[dbo].[InsertComputer]";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@computerName", localAdmin.HostName);
                    sqlCommand.Parameters.AddWithValue("@localScan", DateTime.Now);
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText =
                        "delete [dbo].[LocalAdmins] where ComputerName = @ComputerName";
                    sqlCommand.Parameters.AddWithValue("@ComputerName", localAdmin.HostName);
                    sqlCommand.ExecuteNonQuery();

                    foreach (Account account in localAdmin.AdminAccounts)
                    {
                        
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText =
                            "INSERT INTO [dbo].[LocalAdmins] ([ComputerName],[AccountName],[Path],[AccountType]) VALUES (@ComputerName, @AccountName, @Path, @AccountType)";
                        sqlCommand.Parameters.AddWithValue("@ComputerName", localAdmin.HostName);
                        sqlCommand.Parameters.AddWithValue("@AccountName", account.Name);
                        sqlCommand.Parameters.AddWithValue("@Path", account.Path);
                        sqlCommand.Parameters.AddWithValue("@AccountType", account.Type);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    
                }
            }
            catch (Exception e)
            {
                //taranamayan ipler
            }
        }
    }
}
