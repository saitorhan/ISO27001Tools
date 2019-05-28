using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dhcp;
using ISO27001Tools.Entities;

namespace ISO27001Tools.GUI
{
    public partial class LocalAdminTest : Form
    {
        private List<LocalAdmin> localAdmins;
        public LocalAdminTest()
        {
            InitializeComponent();
            localAdmins = new List<LocalAdmin>();
        }

        private void radioButtonSingleIp_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkedRadioButton = sender as RadioButton;

            if (checkedRadioButton.Text.Contains("DHCP") && checkedRadioButton.Checked)
            {
                labelIP.Text = "Sorgulanacak DHCP Scope";
            }
            else
            {
                labelIP.Text = "Sorgulanacak IP";
            }
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            dataGridViewComputers.Rows.Clear();
            localAdmins.Clear();

            if (radioButtonDHCPScope.Checked)
            {
                
            }
            else
            {
                
            }

            localAdminBindingSource.DataSource = localAdmins;
        }


        private void localAdminBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            LocalAdmin localAdmin = localAdminBindingSource.Current as LocalAdmin;
            if (localAdmin == null)
            {
                return;
            }
            listBoxLocalAdmins.DataSource = localAdmin.AdminAccounts;
        }

        private void LocalAdminTest_Load(object sender, EventArgs e)
        {
            labelScanningIp.Text = String.Empty;
        }
    }

    
}
