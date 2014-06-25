using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Portfolio
{
    public class AccountSimpleValue
    {
        public double? value { get; set; }
        public string number { get; set; }
        public string managementStyle { get; set; }
        public bool isActive { get; set; }
        public int clientId { get; set; }
        public string custodian { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }
}
