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
    public sealed class BBCSignIn_SuccessfullyStep :BaseClass
    {
        public BBCSignInPage page;


        [Test]
        [Given(@"I enter valid Email in the email section")]
        public void GivenIEnterValidEmailInTheEmailSection()
        {
            BBCSignInPage page = new BBCSignInPage();

            page.InputEmail();
            Thread.Sleep(1000);
            InSertReportingSteps();

        }

        [Test]
        [Then(@"I should be redirected to BBC account page veryfy by account being diplayed")]
        public void ThenIShouldBeRedirectedToBBCAccountPageVeryfyByAccountBeingDiplayed()

        { 
           BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.AccountDisplayed).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }
        [Test]
        [Then(@"I should be redirected to BBC account page veryfy by regitered username being displayed")]
        public void ThenIShouldBeRedirectedToBBCAccountPageVeryfyByRegiteredUsernameBeingDisplayed()
        {

           BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.AccountDisplayed).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();



        }
        [Test]
        [Given(@"I enter valid (.*) in the email section")]
        public void GivenIEnterValidInTheEmailSection(string Email)
        {
            ObjectRepository.driver.FindElement(By.Id("user-identifier-input")).SendKeys(Email);
            Thread.Sleep(1000);
            InSertReportingSteps();

        }

        [Test]
        [Then(@"I should be redirected to BBC account page veryfy by account being displayed")]
        public void ThenIShouldBeRedirectedToBBCAccountPageVeryfyByAccountBeingDisplayed()
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.AccountDisplayed).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();


        }
        [Test]
        [Given(@"I enter valid username in the username section")]
        public void GivenIEnterValidUsernameInTheUsernameSection()
        {

            BBCSignInPage page = new BBCSignInPage();

            page.InputUsername();
            Thread.Sleep(1000);
            InSertReportingSteps();
        }
    }


    }

