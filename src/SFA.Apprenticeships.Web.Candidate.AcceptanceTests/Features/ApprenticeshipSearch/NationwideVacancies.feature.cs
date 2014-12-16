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
namespace SFA.Apprenticeships.Web.Candidate.AcceptanceTests.Features.ApprenticeshipSearch
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Nationwide apprenticeships")]
    [NUnit.Framework.CategoryAttribute("US500")]
    public partial class NationwideApprenticeshipsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NationwideVacancies.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Nationwide apprenticeships", "As a candidate\r\nI want to be able to see apprenticeships that exist nationwide\r\ns" +
                    "o that I can see opportunities that may be of interest to me irrespective of my " +
                    "location", ProgrammingLanguage.CSharp, new string[] {
                        "US500"});
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
#line 7
#line 8
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("I am logged out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("I am on the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("After search I see the local apprenticeships")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void AfterSearchISeeTheLocalApprenticeships()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("After search I see the local apprenticeships", new string[] {
                        "SmokeTests"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 15
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "Location",
                        "London"});
            table1.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 16
 testRunner.When("I enter data", ((string)(null)), table1, "When ");
#line 20
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table2.AddRow(new string[] {
                        "LocalLocationTypeLink",
                        "Does Not Exist",
                        ""});
            table2.AddRow(new string[] {
                        "NationwideLocationTypeLink",
                        "Exists",
                        ""});
#line 22
 testRunner.And("I see", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("After clicking on nationwide apprenticeships I see them")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void AfterClickingOnNationwideApprenticeshipsISeeThem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("After clicking on nationwide apprenticeships I see them", new string[] {
                        "SmokeTests"});
#line 28
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 29
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Location",
                        "London"});
            table3.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 30
 testRunner.When("I enter data", ((string)(null)), table3, "When ");
#line 34
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.When("I choose NationwideLocationTypeLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table4.AddRow(new string[] {
                        "LocalLocationTypeLink",
                        "Exists",
                        ""});
            table4.AddRow(new string[] {
                        "NationwideLocationTypeLink",
                        "Does Not Exist",
                        ""});
#line 38
 testRunner.And("I see", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Nationwide apprenticeships cannot have their sort order changed")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void NationwideApprenticeshipsCannotHaveTheirSortOrderChanged()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nationwide apprenticeships cannot have their sort order changed", new string[] {
                        "SmokeTests"});
#line 44
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 45
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "Location",
                        "London"});
            table5.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 46
 testRunner.When("I enter data", ((string)(null)), table5, "When ");
#line 50
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.When("I choose NationwideLocationTypeLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.Then("I wait 0 seconds for SortOrderingDropDown to become disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Nationwide apprenticeships do not show distance")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void NationwideApprenticeshipsDoNotShowDistance()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nationwide apprenticeships do not show distance", new string[] {
                        "SmokeTests"});
#line 57
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 58
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "Location",
                        "London"});
            table6.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 59
 testRunner.When("I enter data", ((string)(null)), table6, "When ");
#line 63
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.When("I choose NationwideLocationTypeLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table7.AddRow(new string[] {
                        "DistanceDisplayed",
                        "Equals",
                        "False"});
            table7.AddRow(new string[] {
                        "ClosingDateDisplayed",
                        "Equals",
                        "True"});
            table7.AddRow(new string[] {
                        "NationwideDisplayed",
                        "Equals",
                        "True"});
#line 67
 testRunner.Then("I see SearchResults list contains", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("nationwide apprenticeships are in closing date order")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void NationwideApprenticeshipsAreInClosingDateOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("nationwide apprenticeships are in closing date order", new string[] {
                        "SmokeTests"});
#line 74
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 75
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "Location",
                        "London"});
            table8.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 76
 testRunner.When("I enter data", ((string)(null)), table8, "When ");
#line 80
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.When("I choose NationwideLocationTypeLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table9.AddRow(new string[] {
                        "ResultsAreInClosingDateOrder",
                        "Equals",
                        "True"});
#line 84
 testRunner.And("I see", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("nationwide apprenticeships found by keyword are in best match order")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void NationwideApprenticeshipsFoundByKeywordAreInBestMatchOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("nationwide apprenticeships found by keyword are in best match order", new string[] {
                        "SmokeTests"});
#line 89
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 90
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "Keywords",
                        "it"});
            table10.AddRow(new string[] {
                        "Location",
                        "London"});
            table10.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 91
 testRunner.When("I enter data", ((string)(null)), table10, "When ");
#line 96
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.When("I choose NationwideLocationTypeLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table11.AddRow(new string[] {
                        "ResultsAreInClosingDateOrder",
                        "Equals",
                        "False"});
#line 100
 testRunner.And("I see", ((string)(null)), table11, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Nationwide apprenticeships found by keyword can be ordered")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void NationwideApprenticeshipsFoundByKeywordCanBeOrdered()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nationwide apprenticeships found by keyword can be ordered", new string[] {
                        "SmokeTests"});
#line 105
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 106
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "Keywords",
                        "it"});
            table12.AddRow(new string[] {
                        "Location",
                        "London"});
            table12.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 107
 testRunner.When("I enter data", ((string)(null)), table12, "When ");
#line 112
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table13.AddRow(new string[] {
                        "SearchResultItemsCount",
                        "Greater Than",
                        "0"});
            table13.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Equals",
                        "Best Match"});
            table13.AddRow(new string[] {
                        "NationwideLocationTypeLink",
                        "Exists",
                        ""});
#line 114
 testRunner.Then("I see", ((string)(null)), table13, "Then ");
#line 119
 testRunner.When("I choose NationwideLocationTypeLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table14.AddRow(new string[] {
                        "LocalLocationTypeLink",
                        "Exists",
                        ""});
            table14.AddRow(new string[] {
                        "NationwideLocationTypeLink",
                        "Does Not Exist",
                        ""});
            table14.AddRow(new string[] {
                        "SortOrderingDropDownItemsCount",
                        "Equals",
                        "2"});
            table14.AddRow(new string[] {
                        "SortOrderingDropDownItemsText",
                        "Equals",
                        "Best Match,Closing Date"});
            table14.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Equals",
                        "Best Match"});
            table14.AddRow(new string[] {
                        "ResultsAreInClosingDateOrder",
                        "Equals",
                        "False"});
#line 121
 testRunner.And("I see", ((string)(null)), table14, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When I\'m seeing nationwide apprenticeships and I change the results per page I re" +
            "main there")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void WhenIMSeeingNationwideApprenticeshipsAndIChangeTheResultsPerPageIRemainThere()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I\'m seeing nationwide apprenticeships and I change the results per page I re" +
                    "main there", new string[] {
                        "SmokeTests"});
#line 131
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 132
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "Location",
                        "London"});
            table15.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 133
 testRunner.When("I enter data", ((string)(null)), table15, "When ");
#line 137
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 139
 testRunner.When("I choose NationwideLocationTypeLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 140
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "ResultsPerPageDropDown",
                        "25 per page"});
#line 141
 testRunner.When("I enter data", ((string)(null)), table16, "When ");
#line 144
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table17.AddRow(new string[] {
                        "LocalLocationTypeLink",
                        "Exists",
                        ""});
            table17.AddRow(new string[] {
                        "NationwideLocationTypeLink",
                        "Does Not Exist",
                        ""});
#line 145
 testRunner.And("I see", ((string)(null)), table17, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When I\'m seeing nationwide apprenticeships and I change the sort order I remain t" +
            "here")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void WhenIMSeeingNationwideApprenticeshipsAndIChangeTheSortOrderIRemainThere()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I\'m seeing nationwide apprenticeships and I change the sort order I remain t" +
                    "here", new string[] {
                        "SmokeTests"});
#line 151
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 152
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "Keywords",
                        "Construction"});
            table18.AddRow(new string[] {
                        "Location",
                        "London"});
            table18.AddRow(new string[] {
                        "WithInDistance",
                        "40 miles"});
#line 153
 testRunner.When("I enter data", ((string)(null)), table18, "When ");
#line 158
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 160
 testRunner.When("I choose NationwideLocationTypeLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 161
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "SortOrderingDropDown",
                        "Closing Date"});
#line 162
 testRunner.When("I enter data", ((string)(null)), table19, "When ");
#line 165
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table20.AddRow(new string[] {
                        "LocalLocationTypeLink",
                        "Exists",
                        ""});
            table20.AddRow(new string[] {
                        "NationwideLocationTypeLink",
                        "Does Not Exist",
                        ""});
#line 166
 testRunner.And("I see", ((string)(null)), table20, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("If there are only nationwide apprenticeships do not show any link")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public virtual void IfThereAreOnlyNationwideApprenticeshipsDoNotShowAnyLink()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("If there are only nationwide apprenticeships do not show any link", new string[] {
                        "SmokeTests"});
#line 172
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 173
 testRunner.Given("I navigated to the ApprenticeshipSearchPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table21.AddRow(new string[] {
                        "Location",
                        "Stanton"});
            table21.AddRow(new string[] {
                        "WithInDistance",
                        "2 miles"});
#line 174
 testRunner.When("I enter data", ((string)(null)), table21, "When ");
#line 178
 testRunner.And("I choose Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
 testRunner.Then("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 180
 testRunner.When("I am on the ApprenticeshipSearchResultPage page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table22.AddRow(new string[] {
                        "NationwideLocationTypeLink",
                        "Does Not Exist",
                        ""});
#line 181
 testRunner.Then("I see", ((string)(null)), table22, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion