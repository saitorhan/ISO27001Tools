using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISO27001Tools.Entities
{

    public class LocalAdmin
    {
        public LocalAdmin()
        {
            AdminAccounts = new List<Account>();
        }
        public string Ip { get; set; }
        public string HostName { get; set; }
        public List<Account> AdminAccounts { get; set; }
    }
}
