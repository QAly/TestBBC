using AventStack.ExtentReports;
using BDDProject.PageObject;
using BDDProject.Settings;
using BDDProject.TestBaseClass;
using NUnit.Framework;
using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDDProject.TestScript.Steps
{
    [Binding]
    [TestFixture]
    public  class BBCSignIn_AccounLockedStep: BaseClass
    {

        public BBCSignInPage page;


        [SetUp]
        [Given(@"As a user I am on ""(.*)""")]
        public void GivenAsAUserIAmOn(string p0)
        {
            InitWebDriver();
            Thread.Sleep(500);
            ObjectRepository.driver.Navigate().GoToUrl(ObjectRepository.config.GetBBCURL());
            Thread.Sleep(1000);
            InitialiseReport();
            BeforeFeature();
            BeforeScenario();
            


        }
        [Test]
        [Given(@"I enter valid Username in the email section")]
        public void GivenIEnterValidUsernameInTheEmailSection()
        {
            BBCSignInPage page = new BBCSignInPage();

            page.InputUsername();
            Thread.Sleep(1000);
            InSertReportingSteps();
            

        }
        [Test]
        [Given(@"wrong Password for the first time")]
        public void GivenWrongPasswordForTheFirstTime(Table table)
        {
            var details = table.CreateDynamicSet();

            foreach (var row in details)
            {

                ObjectRepository.driver.FindElement(By.Id("password-input")).SendKeys(row.Password);
                Thread.Sleep(1000);
                InSertReportingSteps();
               

            }
        }
        [Test]
        [Given(@"I enter invalid Password for the second time")]
        public void GivenIEnterInvalidPasswordForTheSecondTime(Table table)
        {
            var details = table.CreateDynamicSet();
          
            foreach (var row in details) {
               
           ObjectRepository.driver.FindElement(By.Id("password-input")).SendKeys(row.Password);
            Thread.Sleep(1000);
             InSertReportingSteps();
                

            }
        }

        [Test]
        [Given(@"I click on ""(.*)"" button")]
        public void GivenIClickOnButton(string p0)
        {
            BBCSignInPage page = new BBCSignInPage();
            page.ClickontSignInButton();
            Thread.Sleep(1000);
            InSertReportingSteps();
            


        }
        [Test]
        [Given(@"I enter incorrect Password for the third time")]
        public void GivenIEnterIncorrectPasswordForTheThirdTime(Table table)
        {
            var details = table.CreateDynamicSet();

            foreach (var row in details)
            {

                ObjectRepository.driver.FindElement(By.Id("password-input")).SendKeys(row.Password);
                Thread.Sleep(1000);
                InSertReportingSteps();
                

            }
        }
        [Test]
        [Given(@"I enter incorrect password for the fourth time")]
        public void GivenIEnterIncorrectPasswordForTheFourthTime(Table table)
        {
            var details = table.CreateDynamicSet();

            foreach (var row in details)
            {

                ObjectRepository.driver.FindElement(By.Id("password-input")).SendKeys(row.Password);
                Thread.Sleep(1000);
                InSertReportingSteps();
                

            }
        }
        [Test]
        [Given(@"I enter incorrect password for the fifth time")]
        public void GivenIEnterIncorrectPasswordForTheFifthTime(Table table)
        {
            var details = table.CreateDynamicSet();

            foreach (var row in details)
            {

                ObjectRepository.driver.FindElement(By.Id("password-input")).SendKeys(row.Password);
                Thread.Sleep(1000);
                InSertReportingSteps();
             

            }
        }
        [Test]
        [Given(@"I enter incorrect password for the sixth time")]
        public void GivenIEnterIncorrectPasswordForTheSixthTime(Table table)
        {
            var details = table.CreateDynamicSet();

            foreach (var row in details)
            {

                ObjectRepository.driver.FindElement(By.Id("password-input")).SendKeys(row.Password);
                Thread.Sleep(1000);
                InSertReportingSteps();
              

            }

        }

        [Test]
        [Then(@"user account should be locked verify by the account locked page being displayed")]
        public void ThenUserAccountShouldBeLockedVerifyByTheAccountLockedPageBeingDisplayed()
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.AccountLocked).Displayed;

            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();




        }





    }
}
