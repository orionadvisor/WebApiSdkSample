using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Portfolio
{

    public class ClientVerbose
    {
        public int? id { get; set; }
        public string name { get; set; }
        public ClientBilling billing { get; set; }
        public object[] recurringAdjustments { get; set; }
        public Feepayingaccount[] feePayingAccounts { get; set; }
        public ClientPortfolio portfolio { get; set; }
        public Householdmember[] householdMembers { get; set; }
        public Note[] notes { get; set; }
        public Document[] documents { get; set; }
        public object[] additionalAccounts { get; set; }
        public Suitability suitability { get; set; }
        public Userdefinedfield[] userDefinedFields { get; set; }
        public Entityoption[] entityOptions { get; set; }
    }

    public class ClientBilling
    {
        public int? billClientId { get; set; }
        public string statusType { get; set; }
        public object[] relatedClients { get; set; }
    }

    public class ClientPortfolio
    {
        public DateTime? startDate { get; set; }
        public bool isActive { get; set; }
        public int? representativeId { get; set; }
        public int? categoryId { get; set; }
        public int? statementDeliveryMethodId { get; set; }
        public string videoStatementDeliveryMethod { get; set; }
        public string createdBy { get; set; }
        public DateTime? createdDate { get; set; }
        public string editedBy { get; set; }
        public DateTime? editedDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string salutation { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string zip { get; set; }
        public string homePhone { get; set; }
        public string homePhoneExt { get; set; }
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
        public object importKey { get; set; }
        public object lastStatementSent { get; set; }
        public object lastStatementSentTo { get; set; }
    }

    public class Suitability
    {
        public string returnObjective { get; set; }
        public string investmentObjective { get; set; }
        public string timeHorizon { get; set; }
        public string stockPercent { get; set; }
        public int? riskTolerance { get; set; }
    }

    public class Feepayingaccount
    {
        public int? accountId { get; set; }
        public string registration { get; set; }
        public string accountType { get; set; }
        public string managementStyle { get; set; }
        public string custodian { get; set; }
        public string accountNumber { get; set; }
        public bool active { get; set; }
        public int? payPercent { get; set; }
    }

    public class Householdmember
    {
        public int? id { get; set; }
        public string type { get; set; }
        public string salutation { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string homePhone { get; set; }
        public string homePhoneExt { get; set; }
        public string fax { get; set; }
        public string faxExt { get; set; }
        public string pager { get; set; }
        public string pagerExt { get; set; }
        public string mobilePhone { get; set; }
        public string businessPhone { get; set; }
        public string businessPhoneExt { get; set; }
        public string otherPhone { get; set; }
        public string otherPhoneExt { get; set; }
        public string email { get; set; }
        public object ssN_TaxID { get; set; }
        public string gender { get; set; }
        public DateTime? dob { get; set; }
        public string webAddress { get; set; }
        public object[] additionalAddresses { get; set; }
    }

    public class Note
    {
        public int? id { get; set; }
        public string text { get; set; }
        public string editedBy { get; set; }
        public DateTime? editedDate { get; set; }
        public string category { get; set; }
        public bool isWebVisible { get; set; }
    }

    public class Document
    {
        public int? id { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string editedBy { get; set; }
        public DateTime? editedDate { get; set; }
        public bool systemGenerated { get; set; }
    }

    public class Userdefinedfield
    {
        public object childParameter { get; set; }
        public string entity { get; set; }
        public int? entityId { get; set; }
        public object entityName { get; set; }
        public int? userDefineDefinitionId { get; set; }
        public int? userDefineDataId { get; set; }
        public string name { get; set; }
        public object category { get; set; }
        public int? type { get; set; }
        public string code { get; set; }
        public int? sequence { get; set; }
        public string value { get; set; }
        public object[] options { get; set; }
        public object input { get; set; }
    }

    public class Entityoption
    {
        public object childParameter { get; set; }
        public string entity { get; set; }
        public int? entityId { get; set; }
        public object entityName { get; set; }
        public int? userDefineDefinitionId { get; set; }
        public int? userDefineDataId { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public int? type { get; set; }
        public string code { get; set; }
        public int? sequence { get; set; }
        public string value { get; set; }
        public string[] options { get; set; }
        public object input { get; set; }
    }

}
