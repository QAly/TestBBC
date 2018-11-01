﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDDProject.TestScript.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("BBCSignIn_AccounLocked")]
    public partial class BBCSignIn_AccounLockedFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "BBCSignIn_AccounLocked.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "BBCSignIn_AccounLocked", @"	Open BBC Page
	Check signing in using valid Email/Username credential
	Validate entering the wrong password too many times
    Also verify that user is redirecting to the account locked page
	Check the right information is displayed to help user to sign in", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 10
#line 11
 testRunner.Given("As a user I am on \"BBCURL\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sigining In with Wrong Password Many Times")]
        [NUnit.Framework.CategoryAttribute("Browser_Chrome")]
        public virtual void SiginingInWithWrongPasswordManyTimes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sigining In with Wrong Password Many Times", null, new string[] {
                        "Browser_Chrome"});
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
this.FeatureBackground();
#line 15
 testRunner.Given("I enter valid Username in the email section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Password"});
            table1.AddRow(new string[] {
                        "TestingBBC21"});
#line 16
 testRunner.And("wrong Password for the first time", ((string)(null)), table1, "And ");
#line 20
 testRunner.And("I click on \"Sigin in\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Password"});
            table2.AddRow(new string[] {
                        "TestingBBC21"});
#line 21
 testRunner.And("I enter invalid Password for the second time", ((string)(null)), table2, "And ");
#line 25
 testRunner.And("I click on \"Sigin in\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Password"});
            table3.AddRow(new string[] {
                        "Testing@BBC21"});
#line 26
 testRunner.And("I enter incorrect Password for the third time", ((string)(null)), table3, "And ");
#line 30
 testRunner.And("I click on \"Sigin in\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Password"});
            table4.AddRow(new string[] {
                        "Testing@BBC21"});
#line 31
 testRunner.And("I enter incorrect password for the fourth time", ((string)(null)), table4, "And ");
#line 35
 testRunner.And("I click on \"Sigin in\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Password"});
            table5.AddRow(new string[] {
                        "Testing@BBC21"});
#line 37
 testRunner.And("I enter incorrect password for the fifth time", ((string)(null)), table5, "And ");
#line 41
 testRunner.And("I click on \"Sigin in\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Password"});
            table6.AddRow(new string[] {
                        "Testing@BBC21"});
#line 42
 testRunner.And("I enter incorrect password for the sixth time", ((string)(null)), table6, "And ");
#line 46
 testRunner.And("I click on \"Sigin in\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.Then("user account should be locked verify by the account locked page being displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion