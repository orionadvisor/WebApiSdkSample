using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Portfolio
{
    public class Portfolio
    {
        public int clientId { get; set; }
        public int registrationId { get; set; }
        public string registrationName { get; set; }
        public string managementStyle { get; set; }
        public string fundFamily { get; set; }
        public double? accountStartValue { get; set; }
        public string accountStartDate { get; set; }
        public bool isManaged { get; set; }
        public bool isActive { get; set; }
        public bool isSweepAccount { get; set; }
        public object importKey { get; set; }
        public string outsideId { get; set; }
        public int? managementStyleId { get; set; }
        public int fundFamilyId { get; set; }
        public int? accountHistoryId { get; set; }
        public string modelName { get; set; }
        public string accountType { get; set; }
        public string custodian { get; set; }
        public int? custodianId { get; set; }
        public string shareClass { get; set; }
        public int? shareClassId { get; set; }
        public string subAdvisor { get; set; }
        public int? subAdvisorId { get; set; }
        public string provider { get; set; }
        public string plan { get; set; }
        public string linkedAccount { get; set; }
        public string businessLine { get; set; }
        public string createdBy { get; set; }
        public string createdDate { get; set; }
        public string editedBy { get; set; }
        public string editedDate { get; set; }
        public int? accountStatusId { get; set; }
        public string accountStatusDescription { get; set; }
    }

    public class AccountVerbose
    {
        public int id { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public object billing { get; set; }
        public Portfolio portfolio { get; set; }
        public object modelingInfo { get; set; }
        public object notes { get; set; }
        public object documents { get; set; }
        public object systematics { get; set; }
        public object accountManagers { get; set; }
        public object recurringAdjustments { get; set; }
        public object generalAccounts { get; set; }
        public object userDefinedFields { get; set; }
        public object entityOptions { get; set; }
    }
}
