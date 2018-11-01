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

namespace BDDProject.TestScript.Steps
{
    [Binding]
    [TestFixture]
    public  class BBCSignIn_PasswordValidationStep : BaseClass
    {

        [Test]
        [Given(@"I enter a (.*) of less than eight characters")]
        public void GivenIEnterAMythOfLessThanEightCharacters(string Password)
        {
            ObjectRepository.driver.FindElement(By.Id("password-input")).SendKeys(Password);
            Thread.Sleep(1000);
            InSertReportingSteps();



        }
        [Test]
        [Then(@"I should be able to see a warning message displayed in the password section")]
        public void ThenIShouldBeAbleToSeeAWarningMessageDisplayedInThePasswordSection()
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.ShortPassword).Displayed;

            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();


        }
        [Test]
        [Given(@"I enter a (.*) that only contain letters")]
        public void GivenIEnterAMythiqueThatOnlyContainLetters(string Password)
        {
            ObjectRepository.driver.FindElement(By.Id("password-input")).SendKeys(Password);
            Thread.Sleep(1000);
            InSertReportingSteps();


        }
        [Then(@"I should be able to see a warning message to include characters")]
        public void ThenIShouldBeAbleToSeeAWarningMessageToIncludeCharacters()
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.PasswordToContainCharacters).Displayed;

            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }

        [Test]
        [Given(@"I enter a (.*) that only contain characters and numbers")]
        public void GivenIEnterAThatOnlyContainCharactersAndNumbers(string Password)
        {

            ObjectRepository.driver.FindElement(By.Id("password-input")).SendKeys(Password);
            Thread.Sleep(1000);
            InSertReportingSteps();


        }[Test]
        [Then(@"I should be able to see a warning message displayed to include letter")]
        public void ThenIShouldBeAbleToSeeAWarningMessageDisplayedToIncludeLetter()
        {


            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.PasswordToContainLetter).Displayed;

            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();



        }

        [Test]
        [Given(@"I input valid username")]
        public void GivenIInputValidUsername()
        {
            BBCSignInPage page = new BBCSignInPage();

            page.InputUsername();
            Thread.Sleep(1000);
            InSertReportingSteps();

        }



    }





}

