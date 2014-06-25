namespace OrionApiSdk.Classes.Portfolio
{
    public class Account
    {
        public int id { get; set; }
        public bool isActive { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string custodian { get; set; }
        public string accountType { get; set; }
        public string managementStyle { get; set; }
        public string modelName { get; set; }
        public double? currentValue { get; set; }
        public string fundFamily { get; set; }
        public double? accountStartValue { get; set; }
        public string createdDate { get; set; }
        public bool isManaged { get; set; }
        public bool isSweepAccount { get; set; }
        public object importKey { get; set; }
        public string outsideId { get; set; }
        public object secondaryAccountNumber { get; set; }
        public int? managementStyleId { get; set; }
        public int fundFamilyId { get; set; }
        public object accountHistoryId { get; set; }
        public int registrationId { get; set; }
        public int clientId { get; set; }
        public int? custodianId { get; set; }
        public string shareClass { get; set; }
        public int? shareClassId { get; set; }
        public string subAdvisor { get; set; }
        public int? subAdvisorId { get; set; }
        public string provider { get; set; }
        public object plan { get; set; }
        public object linkedAccount { get; set; }
        public string modelGroupNumber { get; set; }
        public bool? isTradingBlocked { get; set; }
        public string tradingInstructions { get; set; }
        public string downloadSource { get; set; }
        public object businessLine { get; set; }
        public string createdBy { get; set; }
        public string accountStartDate { get; set; }
        public string editedBy { get; set; }
        public string editedDate { get; set; }
        public int? accountStatusId { get; set; }
        public string accountStatusDescription { get; set; }
        public int? feeScheduleId { get; set; }
        public string feeSchedule { get; set; }
        public int? masterPayoutScheduleId { get; set; }
        public string masterPayoutSchedule { get; set; }
    }
}
