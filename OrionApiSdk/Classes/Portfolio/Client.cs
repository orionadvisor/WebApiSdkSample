using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Portfolio
{
    public class Client
    {
        public int id { get; set; }
        public bool isActive { get; set; }
        public double? aum { get; set; }
        public string representativeName { get; set; }
        public int representativeId { get; set; }
        public int categoryId { get; set; }
        public int? statementDeliveryMethodId { get; set; }
        public string category { get; set; }
        public string statementDeliveryMethod { get; set; }
        public string createdBy { get; set; }
        public string createdDate { get; set; }
        public string editedBy { get; set; }
        public string editedDate { get; set; }
        public string startDate { get; set; }
        public object importKey { get; set; }
        public object lastStatementSent { get; set; }
        public object lastStatementSentTo { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string name { get; set; }
        public string homePhone { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string salutation { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string zip { get; set; }
        public string fax { get; set; }
        public string faxExt { get; set; }
        public string pager { get; set; }
        public string pagerExt { get; set; }
        public string mobilePhone { get; set; }
        public string businessPhone { get; set; }
        public string businessPhoneExt { get; set; }
        public string otherPhone { get; set; }
        public string otherPhoneExt { get; set; }
        public string reportName { get; set; }
        public object company { get; set; }
        public string jobTitle { get; set; }
        public string ssN_TaxID { get; set; }
        public string gender { get; set; }
        public object dob { get; set; }
        public string webAddress { get; set; }
        public string homePhoneExt { get; set; }
    }
}
