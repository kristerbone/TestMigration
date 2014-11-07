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
namespace SFA.Apprenticeships.Web.Candidate.AcceptanceTests.Features.Registration
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Register Candidate")]
    [NUnit.Framework.CategoryAttribute("US413")]
    public partial class RegisterCandidateFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RegisterCandidate.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Register Candidate", "In order to apply for a vacnacy\r\nAs an apprentice\r\nI want to be able to register " +
                    "for the service", ProgrammingLanguage.CSharp, new string[] {
                        "US413"});
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
#line 8
#line 9
 testRunner.Given("I navigated to the HomePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When("I am on the HomePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a candidate I am on the registration page and all required fields are present " +
            "and all validators show")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void AsACandidateIAmOnTheRegistrationPageAndAllRequiredFieldsArePresentAndAllValidatorsShow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I am on the registration page and all required fields are present " +
                    "and all validators show", new string[] {
                        "SmokeTests"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 14
 testRunner.Given("I navigated to the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.And("I wait to see Firstname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("I wait to see Lastname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("I wait to see Day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I wait to see Month", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("I wait to see Year", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("I wait to see EmailAddress", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("I wait to see Password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("I wait to see ConfirmPassword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("I wait to see HasAcceptedTermsAndConditions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I choose CreateAccountButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("I wait to see ValidationSummary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table1.AddRow(new string[] {
                        "ValidationSummaryCount",
                        "Equals",
                        "12"});
#line 27
 testRunner.Then("I see", ((string)(null)), table1, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table2.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter first name"});
            table2.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#firstname"});
#line 30
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table2, "And ");
#line 34
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table3.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Please enter last name"});
            table3.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#lastname"});
#line 35
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a candidate on the registration page I want to be able to pick my address from" +
            " a list returned from the postcode search")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void AsACandidateOnTheRegistrationPageIWantToBeAbleToPickMyAddressFromAListReturnedFromThePostcodeSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate on the registration page I want to be able to pick my address from" +
                    " a list returned from the postcode search", new string[] {
                        "SmokeTests"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 42
 testRunner.Given("I navigated to the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "PostcodeSearch",
                        "N7 8LS"});
#line 44
 testRunner.And("I enter data", ((string)(null)), table4, "And ");
#line 47
 testRunner.And("I choose FindAddresses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table5.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Flat A, 6 Furlong Road"});
            table5.AddRow(new string[] {
                        "AddressLine1",
                        "Equals",
                        "Flat A"});
            table5.AddRow(new string[] {
                        "AddressLine2",
                        "Equals",
                        "6 Furlong Road"});
            table5.AddRow(new string[] {
                        "AddressLine3",
                        "Equals",
                        "London"});
            table5.AddRow(new string[] {
                        "AddressLine4",
                        "Equals",
                        "Islington"});
            table5.AddRow(new string[] {
                        "Postcode",
                        "Equals",
                        "N7 8LS"});
            table5.AddRow(new string[] {
                        "Uprn",
                        "Equals",
                        "5300034721"});
            table5.AddRow(new string[] {
                        "Latitude",
                        "Equals",
                        "51.54751633697479"});
            table5.AddRow(new string[] {
                        "Longitude",
                        "Equals",
                        "-0.10660693737952387"});
#line 48
 testRunner.And("I am on AddressDropdown list item matching criteria", ((string)(null)), table5, "And ");
#line 59
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table6.AddRow(new string[] {
                        "AddressLine1",
                        "Equals",
                        "Flat A"});
            table6.AddRow(new string[] {
                        "AddressLine2",
                        "Equals",
                        "6 Furlong Road"});
            table6.AddRow(new string[] {
                        "AddressLine3",
                        "Equals",
                        "London"});
            table6.AddRow(new string[] {
                        "AddressLine4",
                        "Equals",
                        "Islington"});
            table6.AddRow(new string[] {
                        "Postcode",
                        "Equals",
                        "N7 8LS"});
            table6.AddRow(new string[] {
                        "Uprn",
                        "Equals",
                        "5300034721"});
            table6.AddRow(new string[] {
                        "Latitude",
                        "Equals",
                        "51.54751633697479"});
            table6.AddRow(new string[] {
                        "Longitude",
                        "Equals",
                        "-0.10660693737952387"});
#line 61
 testRunner.Then("I see", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a candidate I want to be told quickly that my email/username is available")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void AsACandidateIWantToBeToldQuicklyThatMyEmailUsernameIsAvailable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I want to be told quickly that my email/username is available", new string[] {
                        "SmokeTests"});
#line 73
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 74
 testRunner.Given("I navigated to the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
 testRunner.And("I have created a new email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailToken}"});
#line 77
 testRunner.And("I enter data", ((string)(null)), table7, "And ");
#line 80
 testRunner.And("I choose Phonenumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table8.AddRow(new string[] {
                        "EmailAddressAvailableMessage",
                        "Does Not Exist",
                        ""});
#line 82
 testRunner.Then("I see", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a candidate I want to be told quickly that my email/username is not available " +
            "if I have already registered")]
        public virtual void AsACandidateIWantToBeToldQuicklyThatMyEmailUsernameIsNotAvailableIfIHaveAlreadyRegistered()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I want to be told quickly that my email/username is not available " +
                    "if I have already registered", ((string[])(null)));
#line 86
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 87
 testRunner.Given("I navigated to the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 88
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "EmailAddress",
                        "nas.exemplar@gmail.com"});
#line 89
 testRunner.And("I enter data", ((string)(null)), table9, "And ");
#line 92
 testRunner.And("I choose Phonenumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.Then("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.Given("I waited for 30 seconds to see EmailAddressAvailableMessage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 95
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table10.AddRow(new string[] {
                        "EmailAddressAvailableMessage",
                        "Equals",
                        "Your email address has already been activated. Please try signing in again. If yo" +
                            "u’ve forgotten your password you can reset it."});
#line 96
 testRunner.Then("I see", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a candidate I want to be submit my registration details so that I can apply fo" +
            "r vacancies")]
        public virtual void AsACandidateIWantToBeSubmitMyRegistrationDetailsSoThatICanApplyForVacancies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I want to be submit my registration details so that I can apply fo" +
                    "r vacancies", ((string[])(null)));
#line 100
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 101
 testRunner.Given("I navigated to the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 102
 testRunner.And("I have created a new email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "PostcodeSearch",
                        "N7 8LS"});
#line 104
 testRunner.And("I enter data", ((string)(null)), table11, "And ");
#line 107
 testRunner.And("I choose FindAddresses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table12.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Flat A, 6 Furlong Road"});
#line 108
 testRunner.And("I am on AddressDropdown list item matching criteria", ((string)(null)), table12, "And ");
#line 111
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "Firstname",
                        "FirstnameTest"});
            table13.AddRow(new string[] {
                        "Lastname",
                        "LastnameTest"});
            table13.AddRow(new string[] {
                        "Day",
                        "01"});
            table13.AddRow(new string[] {
                        "Month",
                        "01"});
            table13.AddRow(new string[] {
                        "Year",
                        "1999"});
            table13.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailToken}"});
            table13.AddRow(new string[] {
                        "Phonenumber",
                        "07999999999"});
            table13.AddRow(new string[] {
                        "Password",
                        "?Password01!"});
            table13.AddRow(new string[] {
                        "ConfirmPassword",
                        "?Password01!"});
#line 113
 testRunner.And("I enter data", ((string)(null)), table13, "And ");
#line 124
 testRunner.And("I choose HasAcceptedTermsAndConditions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And("I choose CreateAccountButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.And("I wait 120 second for the ActivationPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And("I get the token for my newly created account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.And("I am on the ActivationPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.And("I wait to see EmailAddress", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.And("I am on the ActivationPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "ActivationCode",
                        "{ActivationToken}"});
#line 132
 testRunner.And("I enter data", ((string)(null)), table14, "And ");
#line 135
 testRunner.And("I am on the ActivationPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.And("I choose ActivateButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.And("I am on the VacancySearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.When("I select the first vacancy in location \"N7 8LS\" that can apply by this website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 139
 testRunner.Then("I am on the VacancyDetailsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
 testRunner.When("I choose ApplyButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 141
 testRunner.Then("I am on the ApplicationPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
 testRunner.When("I choose MyApplicationsLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 143
 testRunner.Then("I am on the MyApplicationsPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As a candidate I must confirm my password")]
        public virtual void AsACandidateIMustConfirmMyPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("As a candidate I must confirm my password", ((string[])(null)));
#line 145
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 146
 testRunner.Given("I navigated to the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 147
 testRunner.And("I have created a new email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "PostcodeSearch",
                        "N7 8LS"});
#line 149
 testRunner.And("I enter data", ((string)(null)), table15, "And ");
#line 152
 testRunner.And("I choose FindAddresses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table16.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Flat A, 6 Furlong Road"});
#line 153
 testRunner.And("I am on AddressDropdown list item matching criteria", ((string)(null)), table16, "And ");
#line 156
 testRunner.And("I choose WrappedElement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "Firstname",
                        "FirstnameTest"});
            table17.AddRow(new string[] {
                        "Lastname",
                        "LastnameTest"});
            table17.AddRow(new string[] {
                        "Day",
                        "01"});
            table17.AddRow(new string[] {
                        "Month",
                        "01"});
            table17.AddRow(new string[] {
                        "Year",
                        "1999"});
            table17.AddRow(new string[] {
                        "EmailAddress",
                        "{EmailToken}"});
            table17.AddRow(new string[] {
                        "Phonenumber",
                        "07999999999"});
            table17.AddRow(new string[] {
                        "Password",
                        "?Password01!"});
            table17.AddRow(new string[] {
                        "ConfirmPassword",
                        "!10drowssaP?"});
#line 158
 testRunner.And("I enter data", ((string)(null)), table17, "And ");
#line 169
 testRunner.And("I choose HasAcceptedTermsAndConditions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
 testRunner.And("I choose CreateAccountButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.Then("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table18.AddRow(new string[] {
                        "ValidationSummaryCount",
                        "Equals",
                        "1"});
#line 173
 testRunner.And("I see", ((string)(null)), table18, "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table19.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "Sorry, your passwords don’t match"});
            table19.AddRow(new string[] {
                        "Href",
                        "Equals",
                        "#Password"});
#line 176
 testRunner.And("I am on ValidationSummaryItems list item matching criteria", ((string)(null)), table19, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I cannot enter letters on day, month and year")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void ICannotEnterLettersOnDayMonthAndYear()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I cannot enter letters on day, month and year", new string[] {
                        "SmokeTests"});
#line 182
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 183
 testRunner.Given("I navigated to the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 184
 testRunner.When("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "Day",
                        "aa"});
            table20.AddRow(new string[] {
                        "Month",
                        "aa"});
            table20.AddRow(new string[] {
                        "Year",
                        "aaaa"});
#line 185
 testRunner.And("I enter data", ((string)(null)), table20, "And ");
#line 190
 testRunner.And("I choose Phonenumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 191
 testRunner.Then("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table21.AddRow(new string[] {
                        "ValidationFieldErrorCount",
                        "Equals",
                        "3"});
#line 192
 testRunner.And("I see", ((string)(null)), table21, "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table22.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "The field Day must be a number."});
#line 195
 testRunner.And("I am on ValidationFieldErrorItems list item matching criteria", ((string)(null)), table22, "And ");
#line 198
 testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table23.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "The field Month must be a number."});
#line 199
 testRunner.And("I am on ValidationFieldErrorItems list item matching criteria", ((string)(null)), table23, "And ");
#line 202
  testRunner.And("I am on the RegisterCandidatePage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table24.AddRow(new string[] {
                        "Text",
                        "Equals",
                        "The field Year must be a number."});
#line 203
 testRunner.And("I am on ValidationFieldErrorItems list item matching criteria", ((string)(null)), table24, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
