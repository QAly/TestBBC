using BDDProject.ComponentHelper;
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
    public  class BBCSignIn_ClickableLinkStep: BaseClass
    {
        public BBCSignInPage page;
       


        [Test]
        [Given(@"I click on Need help Link")]
        public void GivenIClickOnNeedHelpLink()
        {
            LinkHelper.ClickLink(By.PartialLinkText("Need help signing in"));

            Thread.Sleep(1000);
            InSertReportingSteps();


        }
        [Test]
        [Then(@"I should be redirected to the help page verify by the page title")]
        public void ThenIShouldBeRedirectedToTheHelpPageVerifyByThePageTitle()
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.NeedHelp).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }
        [Test]
        [Given(@"I click on Register now Link")]
        public void GivenIClickOnRegisterNowLink()
        {
            LinkHelper.ClickLink(By.LinkText("Register now"));

            Thread.Sleep(1000);
            InSertReportingSteps();
           

        }
        [Test]
        [Then(@"I should be redirected to the Register with BBC page verify by ""(.*)"" being displayed")]
        public void ThenIShouldBeRedirectedToTheRegisterWithBBCPageVerifyByBeingDisplayed(string p0)
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.Register).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();


        }
        [Test]
        [Given(@"I click on Find out more about BBC account  Link")]
        public void GivenIClickOnFindOutMoreAboutBBCAccountLink()
        {
            LinkHelper.ClickLink(By.PartialLinkText("Find out more"));

            Thread.Sleep(1000);
            InSertReportingSteps();
           

        }
        [Test]
        [Then(@"I should be redirected to  Creating and Using your BBC account page verify by ""(.*)"" being displayed")]
        public void ThenIShouldBeRedirectedToCreatingAndUsingYourBBCAccountPageVerifyByBeingDisplayed(string p0)
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.Accountusage).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();
        }
        [Test]
        [Given(@"I click on Abbout the BBC Link")]
        public void GivenIClickOnAbboutTheBBCLink()
        {
            LinkHelper.ClickLink(By.LinkText("About the BBC"));

            Thread.Sleep(1000);
            InSertReportingSteps();
           

        }
        [Test]
        [Then(@"I should be redirected to About  the BBC page verify by the page title")]
        public void ThenIShouldBeRedirectedToAboutTheBBCPageVerifyByThePageTitle()
        {
            string expectedTitle = ObjectRepository.driver.Title;
            
            string actualTitle = "BBC - About the BBC - About the BBC";

            Assert.AreEqual(actualTitle, expectedTitle);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }
        [Test]
        [Given(@"I click on Privacy Policy Link")]
        public void GivenIClickOnPrivacyPolicyLink()
        {
            LinkHelper.ClickLink(By.LinkText("Privacy Policy"));

            Thread.Sleep(1000);
            InSertReportingSteps();
          
        }
        [Test]
        [Then(@"I should be redirected to Your Information and Privacy page verify by ""(.*)"" being displayed")]
        public void ThenIShouldBeRedirectedToYourInformationAndPrivacyPageVerifyByBeingDisplayed(string p0)
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.Privacy).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }
        [Test]
        [Given(@"I click on cookies Link")]
        public void GivenIClickOnCookiesLink()
        {
            LinkHelper.ClickLink(By.LinkText("Cookies"));

            Thread.Sleep(1000);
            InSertReportingSteps();
            

        }

        [Test]
        [Then(@"I should be redirected to the Cookies and Browser Settings page verify by ""(.*)"" being displayed")]
        public void ThenIShouldBeRedirectedToTheCookiesAndBrowserSettingsPageVerifyByBeingDisplayed(string p0)
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.Cookies).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }
        [Test]
        [Given(@"I click on Accessibility help Link")]
        public void GivenIClickOnAccessibilityHelpLink()
        {
            LinkHelper.ClickLink(By.LinkText("Accessibility Help"));

            Thread.Sleep(1000);
            InSertReportingSteps();
          

        }
        [Test]
        [Then(@"I should be redirected to My Web my way page verify by ""(.*)"" being displayed")]
        public void ThenIShouldBeRedirectedToMyWebMyWayPageVerifyByBeingDisplayed(string p0)
        {
            string expectedTitle = ObjectRepository.driver.Title;

            string actualTitle = "BBC - My Web My Way - Home";

            Assert.AreEqual(actualTitle, expectedTitle);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();



        }
        [Test]
        [Given(@"I click on parental Guidance Link")]
        public void GivenIClickOnParentalGuidanceLink()
        {
            LinkHelper.ClickLink(By.LinkText("Parental Guidance"));

            Thread.Sleep(1000);
            InSertReportingSteps();
          

        }

        [Test]
        [Then(@"I should be redirected to the Parental Guidance page verify by the page title")]
        public void ThenIShouldBeRedirectedToTheParentalGuidancePageVerifyByThePageTitle()
        {

            string expectedTitle = ObjectRepository.driver.Title;

            string actualTitle = "BBC iPlayer - Parental Controls";

            Assert.AreEqual(actualTitle, expectedTitle);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();


            //BBCSignInPage page = new BBCSignInPage();
            //bool status = ObjectRepository.driver.FindElement(page.PGuidance).Displayed;
            //Assert.True(status);
            //Thread.Sleep(1000);

        }
        [Test]
        [Given(@"I click on Contact the BBC Link")]
        public void GivenIClickOnContactTheBBCLink()
        {
            LinkHelper.ClickLink(By.LinkText("Contact the BBC"));

            Thread.Sleep(1000);
            InSertReportingSteps();
          

        }

        [Then(@"I should be redirected to the Contact the BBC page verify by the page title")]
        public void ThenIShouldBeRedirectedToTheContactTheBBCPageVerifyByThePageTitle()
        {
            string expectedTitle = ObjectRepository.driver.Title;

            string actualTitle = "BBC Contact Us - Home";

            Assert.AreEqual(actualTitle, expectedTitle);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();


        }
        [Test]
        [Given(@"I click on Get Personanlised Newsletters Link")]
        public void GivenIClickOnGetPersonanlisedNewslettersLink()
        {
            LinkHelper.ClickLink(By.LinkText("Get Personalised Newsletters"));

            Thread.Sleep(1000);
            InSertReportingSteps();
            

        }
        [Test]
        [Then(@"I should be redirected to Get Personalised Newsletters page verify by the page title")]
        public void ThenIShouldBeRedirectedToGetPersonalisedNewslettersPageVerifyByThePageTitle()
        {
            string expectedTitle = ObjectRepository.driver.Title;

            string actualTitle = "BBC - Emails made for you";

            Assert.AreEqual(actualTitle, expectedTitle);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }
        [Test]
        [Given(@"I click on the cross button")]
        public void GivenIClickOnTheCrossButton()
        {
            BBCSignInPage page = new BBCSignInPage();
            ButtonHelper.ClickButton(page.CloseButton);

            Thread.Sleep(1000);
            InSertReportingSteps();
           
        }

        [Then(@"I should be redirected to welcome to BBC page verify by the page title")]
        public void ThenIShouldBeRedirectedToWelcomeToBBCPageVerifyByThePageTitle()
        {
            string expectedTitle = ObjectRepository.driver.Title;

            string actualTitle = "BBC - Home";

            Assert.AreEqual(actualTitle, expectedTitle);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();


        }

    }
}
