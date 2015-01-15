﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SFA.Apprenticeships.Web.Candidate.AcceptanceTests.Features.TraineeshipApplication
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Dashboard find vacancy links")]
    public partial class DashboardFindVacancyLinksFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ShowFindVacancyLinks.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Dashboard find vacancy links", "As a candidate \r\nI want links to find relevant vacancies", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line 6
 testRunner.Given("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.And("I am logged out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.And("I navigated to the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.Then("I am on the TraineeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I have applied for neither traineeships nor apprenticeships")]
        [NUnit.Framework.CategoryAttribute("US586")]
        public virtual void IHaveAppliedForNeitherTraineeshipsNorApprenticeships()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I have applied for neither traineeships nor apprenticeships", new string[] {
                        "US586"});
#line 12
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 13
 testRunner.Given("I have an empty dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.And("I navigated to the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When("I am on the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailAddressToken}"});
            table1.AddRow(new string[] {
                        "Password",
                        "{PasswordToken}"});
#line 16
 testRunner.And("I enter data", ((string)(null)), table1, "And ");
#line 20
 testRunner.And("I choose SignInButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.Then("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table2.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Does Not Exist",
                        ""});
            table2.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Does Not Exist",
                        ""});
            table2.AddRow(new string[] {
                        "FindApprenticeshipButton",
                        "Exists",
                        ""});
            table2.AddRow(new string[] {
                        "TraineeshipsPrompt",
                        "Does Not Exist",
                        ""});
#line 22
 testRunner.And("I see", ((string)(null)), table2, "And ");
#line 28
 testRunner.When("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.And("I choose MySettingsLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table3.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
            table3.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Does Not Exist",
                        ""});
#line 31
 testRunner.And("I see", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I have applied for one or more apprenticeship and no traineeships")]
        [NUnit.Framework.CategoryAttribute("US586")]
        public virtual void IHaveAppliedForOneOrMoreApprenticeshipAndNoTraineeships()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I have applied for one or more apprenticeship and no traineeships", new string[] {
                        "US586"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 38
 testRunner.Given("I have an empty dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.And("I add 2 applications in \"Draft\" state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("I navigated to the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.When("I am on the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailAddressToken}"});
            table4.AddRow(new string[] {
                        "Password",
                        "{PasswordToken}"});
#line 42
 testRunner.And("I enter data", ((string)(null)), table4, "And ");
#line 46
 testRunner.And("I choose SignInButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.Then("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table5.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
            table5.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Does Not Exist",
                        ""});
            table5.AddRow(new string[] {
                        "FindApprenticeshipButton",
                        "Does Not Exist",
                        ""});
            table5.AddRow(new string[] {
                        "TraineeshipsPrompt",
                        "Does Not Exist",
                        ""});
#line 48
 testRunner.And("I see", ((string)(null)), table5, "And ");
#line 54
 testRunner.When("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.And("I choose MySettingsLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table6.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
            table6.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Does Not Exist",
                        ""});
#line 57
 testRunner.And("I see", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I have applied for six or more unsuccessful apprenticeships and no traineeships")]
        [NUnit.Framework.CategoryAttribute("US586")]
        public virtual void IHaveAppliedForSixOrMoreUnsuccessfulApprenticeshipsAndNoTraineeships()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I have applied for six or more unsuccessful apprenticeships and no traineeships", new string[] {
                        "US586"});
#line 63
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 64
 testRunner.Given("I have an empty dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
 testRunner.And("I add 6 applications in \"Unsuccessful\" state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("I navigated to the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.When("I am on the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailAddressToken}"});
            table7.AddRow(new string[] {
                        "Password",
                        "{PasswordToken}"});
#line 68
 testRunner.And("I enter data", ((string)(null)), table7, "And ");
#line 72
 testRunner.And("I choose SignInButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.Then("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table8.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
            table8.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Exists",
                        ""});
            table8.AddRow(new string[] {
                        "FindApprenticeshipButton",
                        "Does Not Exist",
                        ""});
            table8.AddRow(new string[] {
                        "TraineeshipsPrompt",
                        "Exists",
                        ""});
#line 74
 testRunner.And("I see", ((string)(null)), table8, "And ");
#line 80
 testRunner.When("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.And("I choose MySettingsLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table9.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
            table9.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Exists",
                        ""});
#line 83
 testRunner.And("I see", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I have applied for six or more unsuccessful apprenticeships one successful appren" +
            "ticeship and no traineeships")]
        [NUnit.Framework.CategoryAttribute("US586")]
        public virtual void IHaveAppliedForSixOrMoreUnsuccessfulApprenticeshipsOneSuccessfulApprenticeshipAndNoTraineeships()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I have applied for six or more unsuccessful apprenticeships one successful appren" +
                    "ticeship and no traineeships", new string[] {
                        "US586"});
#line 89
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 90
 testRunner.Given("I have an empty dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
 testRunner.And("I add 6 applications in \"Unsuccessful\" state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("I add 6 applications in \"Successful\" state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("I navigated to the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("I am on the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailAddressToken}"});
            table10.AddRow(new string[] {
                        "Password",
                        "{PasswordToken}"});
#line 95
 testRunner.And("I enter data", ((string)(null)), table10, "And ");
#line 99
 testRunner.And("I choose SignInButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.Then("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table11.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
            table11.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Exists",
                        ""});
            table11.AddRow(new string[] {
                        "FindApprenticeshipButton",
                        "Does Not Exist",
                        ""});
            table11.AddRow(new string[] {
                        "TraineeshipsPrompt",
                        "Does Not Exist",
                        ""});
#line 101
 testRunner.And("I see", ((string)(null)), table11, "And ");
#line 107
 testRunner.When("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
 testRunner.And("I choose MySettingsLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table12.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
            table12.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Exists",
                        ""});
#line 110
 testRunner.And("I see", ((string)(null)), table12, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I have applied for one or more traineeships and no apprenticeships")]
        [NUnit.Framework.CategoryAttribute("US586")]
        public virtual void IHaveAppliedForOneOrMoreTraineeshipsAndNoApprenticeships()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I have applied for one or more traineeships and no apprenticeships", new string[] {
                        "US586"});
#line 116
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 117
 testRunner.Given("I have an empty dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 118
 testRunner.And("I applied for 1 traineeships", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("I navigated to the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.When("I am on the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailAddressToken}"});
            table13.AddRow(new string[] {
                        "Password",
                        "{PasswordToken}"});
#line 121
 testRunner.And("I enter data", ((string)(null)), table13, "And ");
#line 125
 testRunner.And("I choose SignInButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.Then("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table14.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
            table14.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Exists",
                        ""});
            table14.AddRow(new string[] {
                        "FindApprenticeshipButton",
                        "Does Not Exist",
                        ""});
            table14.AddRow(new string[] {
                        "TraineeshipsPrompt",
                        "Does Not Exist",
                        ""});
#line 127
 testRunner.And("I see", ((string)(null)), table14, "And ");
#line 133
 testRunner.When("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.And("I choose MySettingsLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table15.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
            table15.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Exists",
                        ""});
#line 136
 testRunner.And("I see", ((string)(null)), table15, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I am not interested in traineeships and I want to dismiss the traineeships prompt" +
            "")]
        [NUnit.Framework.CategoryAttribute("US658")]
        public virtual void IAmNotInterestedInTraineeshipsAndIWantToDismissTheTraineeshipsPrompt()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I am not interested in traineeships and I want to dismiss the traineeships prompt" +
                    "", new string[] {
                        "US658"});
#line 142
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 143
 testRunner.Given("I have an empty dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 144
 testRunner.And("I add 6 applications in \"Unsuccessful\" state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.And("I navigated to the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.When("I am on the LoginPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailAddressToken}"});
            table16.AddRow(new string[] {
                        "Password",
                        "{PasswordToken}"});
#line 147
 testRunner.And("I enter data", ((string)(null)), table16, "And ");
#line 151
 testRunner.And("I choose SignInButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.Then("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table17.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
            table17.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Exists",
                        ""});
            table17.AddRow(new string[] {
                        "TraineeshipsPrompt",
                        "Exists",
                        ""});
#line 153
 testRunner.And("I see", ((string)(null)), table17, "And ");
#line 158
 testRunner.When("I choose DismissTraineeshipPromptsLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 159
 testRunner.Then("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table18.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
            table18.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Exists",
                        ""});
            table18.AddRow(new string[] {
                        "TraineeshipsPrompt",
                        "Does Not Exist",
                        ""});
#line 160
 testRunner.And("I see", ((string)(null)), table18, "And ");
#line 165
 testRunner.When("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 166
 testRunner.And("I choose MySettingsLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 167
 testRunner.Then("I am on the SettingsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table19.AddRow(new string[] {
                        "FindApprenticeshipLink",
                        "Exists",
                        ""});
            table19.AddRow(new string[] {
                        "FindTraineeshipLink",
                        "Exists",
                        ""});
#line 168
 testRunner.And("I see", ((string)(null)), table19, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion