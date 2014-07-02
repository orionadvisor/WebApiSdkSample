using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Portfolio
{

    
public class RegistrationVerbose
{
public int? id { get; set; }
public string name { get; set; }
public RegistrationPortfolio portfolio { get; set; }
public object[] notes { get; set; }
public object[] beneficiaries { get; set; }
public RegistrationSuitability suitability { get; set; }
public Userdefinedfield[] userDefinedFields { get; set; }
public Entityoption[] entityOptions { get; set; }
}

public class RegistrationPortfolio
{
public string name { get; set; }
public string firstName { get; set; }
public string lastName { get; set; }
public string typeCode { get; set; }
public string accountType { get; set; }
public bool isActive { get; set; }
public int? clientId { get; set; }
public int? typeId { get; set; }
public string company { get; set; }
public string jobTitle { get; set; }
public string ssN_TaxID { get; set; }
public DateTime? dob { get; set; }
public string gender { get; set; }
public string createdBy { get; set; }
public DateTime? createdDate { get; set; }
public string editedBy { get; set; }
public DateTime? editedDate { get; set; }
public object dateOfDeath { get; set; }
}

public class RegistrationSuitability
{
public object netWorthIncludingResidence { get; set; }
public object netWorthExcludingResidence { get; set; }
public object liquidNetWorth { get; set; }
public object investmentKnowledge { get; set; }
public object riskExposure { get; set; }
public object investmentExperience { get; set; }
public string returnObjective { get; set; }
public string investmentObjective { get; set; }
public string timeHorizon { get; set; }
public string stockPercent { get; set; }
public int? riskTolerance { get; set; }
public int? netWorth { get; set; }
public int? netIncome { get; set; }
}




}
