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
    [NUnit.Framework.DescriptionAttribute("BBCLogin_EmailUsernameValidation")]
    public partial class BBCLogin_EmailUsernameValidationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "BBCSignIn_EmailUsernameValidation.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "BBCLogin_EmailUsernameValidation", "\tOpen BBC Page\r\n\tcheck signing in using invalid Email or username credential\r\n\tCh" +
                    "eck the right information is displayed to help user to sign in correctly", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 7
#line 8
 testRunner.Given("As a user I am on \"BBCURL\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sigining In with Invalid Email")]
        [NUnit.Framework.CategoryAttribute("Browser_Chrome")]
        [NUnit.Framework.TestCaseAttribute("keleba@com", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10@", null)]
        [NUnit.Framework.TestCaseAttribute("lydiekelebalydie@gmail.com", null)]
        public virtual void SiginingInWithInvalidEmail(string email, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser_Chrome"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sigining In with Invalid Email", null, @__tags);
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 12
 testRunner.Given(string.Format("As a user I enter invalid {0} in the email section", email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.And("I enter valid Password in the password section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("I click on Sigin in button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("I should be able to see a warning message displayed in the email section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sigining In with a Valid Email not linked to a BBC Account")]
        [NUnit.Framework.CategoryAttribute("Browser_Chrome")]
        [NUnit.Framework.TestCaseAttribute("kelebalydie@gmail.co.uk", null)]
        [NUnit.Framework.TestCaseAttribute("senylydie@hotmail.co.uk", null)]
        public virtual void SiginingInWithAValidEmailNotLinkedToABBCAccount(string email, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser_Chrome"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sigining In with a Valid Email not linked to a BBC Account", null, @__tags);
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 25
 testRunner.Given(string.Format("I input {0} in the dedicated email section", email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.And("I enter valid Password in the password section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When("I click on Sigin in button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("I should be able to see a warning message displayed in the email section for vali" +
                    "d Email Not Linked to a BBC account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sigining In with Invalid Username including Acceptable characters")]
        [NUnit.Framework.CategoryAttribute("Browser_Chrome")]
        [NUnit.Framework.TestCaseAttribute("lydie10233%", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10233$", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10233?", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10233#", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10233~", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10123^", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10123=", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10123_", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10123+", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10123}", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10123{", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10123\\", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10123/", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10123\'", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10123-", null)]
        [NUnit.Framework.TestCaseAttribute("kelebalydiegmailcom", null)]
        public virtual void SiginingInWithInvalidUsernameIncludingAcceptableCharacters(string username, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser_Chrome"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sigining In with Invalid Username including Acceptable characters", null, @__tags);
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 38
 testRunner.Given(string.Format("I input {0} in the username box", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.And("I enter valid Password in the password section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.When("I click on Sigin in button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("I should be able to see a warning message displayed in the email section for acce" +
                    "ptable characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sigining In with Invalid Username Including Characters Not Accepted")]
        [NUnit.Framework.CategoryAttribute("Browser_Chrome")]
        [NUnit.Framework.TestCaseAttribute("lydie10.", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10*", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10!", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10,", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10:", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10!", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10&", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10>", null)]
        [NUnit.Framework.TestCaseAttribute("lydie10<", null)]
        public virtual void SiginingInWithInvalidUsernameIncludingCharactersNotAccepted(string username, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser_Chrome"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sigining In with Invalid Username Including Characters Not Accepted", null, @__tags);
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 64
 testRunner.Given(string.Format("I enter invalid {0} including unacceptable charaters", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
 testRunner.And("I enter valid Password in the password section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.When("I click on Sigin in button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("I should be able to see a warning message displayed in the email section to inclu" +
                    "de characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sigining In with blank EmailUsername or Password")]
        [NUnit.Framework.CategoryAttribute("Browser_Chrome")]
        public virtual void SiginingInWithBlankEmailUsernameOrPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sigining In with blank EmailUsername or Password", null, new string[] {
                        "Browser_Chrome"});
#line 83
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 84
 testRunner.Given("I enter no Username in the username section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 85
 testRunner.And("I enter no password in the password section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.When("I click on Sigin in button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.Then("I should be able to see a warning message displayed in the username section as we" +
                    "ll as in password section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sigining In with blank EmailUsername")]
        [NUnit.Framework.CategoryAttribute("Chrome_Browser")]
        public virtual void SiginingInWithBlankEmailUsername()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sigining In with blank EmailUsername", null, new string[] {
                        "Chrome_Browser"});
#line 91
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 92
    testRunner.Given("I enter no Username in the username section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 93
 testRunner.And("I enter valid Password in the password section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("I click on Sigin in button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("I should be able to see a warning message displayed in the username section as we" +
                    "ll as in password section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sigining In with blank Password")]
        [NUnit.Framework.CategoryAttribute("Chrome_Browser")]
        public virtual void SiginingInWithBlankPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sigining In with blank Password", null, new string[] {
                        "Chrome_Browser"});
#line 99
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 100
    testRunner.Given("I enter valid Username in the email section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 101
 testRunner.And("I enter no password in the password section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.When("I click on Sigin in button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("I should be able to see a warning message displayed in the username section as we" +
                    "ll as in password section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sigining In with long username")]
        [NUnit.Framework.CategoryAttribute("Browser_Chrome")]
        [NUnit.Framework.TestCaseAttribute("lydielydielydielydielydielydielydielydielydielydielydielydie", null)]
        public virtual void SiginingInWithLongUsername(string username, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser_Chrome"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sigining In with long username", null, @__tags);
#line 106
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 107
 testRunner.Given(string.Format("I enter long {0} in the email", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 108
 testRunner.And("I enter valid Password in the password section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.When("I click on Sigin in button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
 testRunner.Then("I should be able to see a warning message displayed in the email section for long" +
                    " username", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
