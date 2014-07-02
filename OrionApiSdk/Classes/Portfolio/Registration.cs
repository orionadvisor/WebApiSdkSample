using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Portfolio
{
    public class Registration
    {
        public int id { get; set; }
        public bool isActive { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string name { get; set; }
        public string accountType { get; set; }
        public double? currentValue { get; set; }
        public string ssN_TaxID { get; set; }
        public DateTime? dob { get; set; }
        public int clientId { get; set; }
        public string typeCode { get; set; }
        public int typeId { get; set; }
        public string company { get; set; }
        public string jobTitle { get; set; }
        public string gender { get; set; }
        public string createdBy { get; set; }
        public string createdDate { get; set; }
        public string editedBy { get; set; }
        public string editedDate { get; set; }
    }
}
