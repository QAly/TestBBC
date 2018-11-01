using BDDProject.PageObject;
using BDDProject.Settings;
using BDDProject.TestBaseClass;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
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
    public sealed class BBCSignIn_EmailUsernameValidationStep : BaseClass
    {
        public BBCSignInPage page;





        [Test]
        [Given(@"As a user I enter invalid (.*) in the email section")]
        public void GivenAsAUserIEnterInvalidKelebalydieGmailcomInTheEmailSection(string Email)

        {
   
                ObjectRepository.driver.FindElement(By.Id("user-identifier-input")).SendKeys(Email );
                Thread.Sleep(1000);
                InSertReportingSteps();
            }


        [Test]
        [Given(@"I enter valid Password in the password section")]
        public void GivenIEnterValidPasswordInThePasswordSection()
        {
            BBCSignInPage page = new BBCSignInPage();

            page.InputPassword();
            Thread.Sleep(1000);
            InSertReportingSteps();
        }
        [Test]
        [When(@"I click on Sigin in button")]
        public void WhenIClickOnSiginInButton()
        {
            BBCSignInPage page = new BBCSignInPage();
            page.ClickontSignInButton();
            Thread.Sleep(1000);
            InSertReportingSteps();
        }
        [Test]
        [Then(@"I should be able to see a warning message displayed in the email section")]
        public void ThenIShouldBeAbleToSeeAWarningMessageDisplayedInTheEmailSection()
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.ProperEmail).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();


        }
        [Test]
        [Given(@"I input (.*) in the dedicated email section")]
        public void GivenIInputKelebalydieGmail_Co_UkInTheDedicatedEmailSection(string Email)
        
       
        {
            ObjectRepository.driver.FindElement(By.Id("user-identifier-input")).SendKeys(Email);
            Thread.Sleep(1000);
            InSertReportingSteps();

        }
        [Test]
        [Then(@"I should be able to see a warning message displayed in the email section for acceptable characters")]
        public void ThenIShouldBeAbleToSeeAWarningMessageDisplayedInTheEmailSectionForAcceptableCharacters()
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.AcceptableCharacters).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }

        [Test]
        [Then(@"I should be able to see a warning message displayed in the email section for valid Email Not Linked to a BBC account")]
        public void ThenIShouldBeAbleToSeeAWarningMessageDisplayedInTheEmailSectionForValidEmailNotLinkedToABBCAccount()
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.AccountNotLinkToBBC).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }


        [Test]
        [Given(@"I input (.*) in the username box")]
        public void GivenIInputLydieInTheUsernameBox(string Username)
        {
            ObjectRepository.driver.FindElement(By.Id("user-identifier-input")).SendKeys(Username);
            Thread.Sleep(1000);
            InSertReportingSteps();

        }

        [Test]
        [Given(@"I enter invalid (.*) including unacceptable charaters")]
        public void GivenIEnterInvalidLydie_IncludingUnacceptableCharaters(string Username)
        {
            ObjectRepository.driver.FindElement(By.Id("user-identifier-input")).SendKeys(Username);
            Thread.Sleep(1000);
            InSertReportingSteps();

        }
        [Test]
        [Then(@"I should be able to see a warning message displayed in the email section for Unacceptable characters")]
        public void ThenIShouldBeAbleToSeeAWarningMessageDisplayedInTheEmailSectionForUnacceptableCharacters()
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.ShowWarningMessageEmailNoValid).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();
        }
        [Test]
      [Then(@"I should be able to see a warning message displayed  for Unacceptable characters")]
        public void ThenIShouldBeAbleToSeeAWarningMessageDisplayedForUnacceptableCharacters()
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.UnacceptableCharacters).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
        
        }


        [Test]
        [Given(@"I enter invalid (.*) characters")]
        public void GivenIEnterInvalidLydieCharacters(string Username)

        {


            ObjectRepository.driver.FindElement(By.Id("user-identifier-input")).SendKeys(Username);
            Thread.Sleep(1000);

        }

        [Test]
        [Then(@"I enter valid Password in the password section")]
        public void ThenIEnterValidPasswordInThePasswordSection()
        {
            BBCSignInPage page = new BBCSignInPage();

            page.InputPassword();
            Thread.Sleep(1000);
            InSertReportingSteps();

        }

        [Test]
        [Then(@"warning message should still show")]
        public void ThenWarningMessageShouldStillShow()
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.ShowWarningMessageEmailNoValid).Displayed;
            Assert.True(status); 
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }

        [Test]
        [Given(@"I enter a valid (.*) in UpperCase")]
        public void GivenIEnterAValidLYDIEInUpperCase(string Username)
        {

            ObjectRepository.driver.FindElement(By.Id("user-identifier-input")).SendKeys(Username);
            Thread.Sleep(1000);
            InSertReportingSteps();


        }
        [Test]
        [Then(@"I should be able to see a warning message displayed in the email section for case sensitive not accepted")]
        public void ThenIShouldBeAbleToSeeAWarningMessageDisplayedInTheEmailSectionForCaseSensitiveNotAccepted()
        {

            BBCSignInPage page = new BBCSignInPage();
            bool Result = ObjectRepository.driver.FindElement(page.ShowWarningMessageEmailNoValid).Displayed;
            Assert.True(Result);

            Thread.Sleep(2000);

                        }
        

        [Test]
        [Given(@"I enter no Username in the username section")]
        public void GivenIEnterNoUsernameInTheUsernameSection()
        {
            ObjectRepository.driver.FindElement(By.Id("user-identifier-input")).SendKeys("");
            Thread.Sleep(1000);
            InSertReportingSteps();

        }
        [Test]
        [Given(@"I enter no password in the password section")]
        public void GivenIEnterNoPasswordInThePasswordSection()
        {

            ObjectRepository.driver.FindElement(By.Id("password-input")).SendKeys("");
            Thread.Sleep(1000);
            InSertReportingSteps();


        }



        [Test]
        [Then(@"I should be able to see a warning message displayed in the username section as well as in password section")]
        public void ThenIShouldBeAbleToSeeAWarningMessageDisplayedInTheUsernameSectionAsWellAsInPasswordSection()
        {

            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.ShowWarningMessageEmailNoValid).Displayed;
            Assert.True(status); // this test is failing because as a user you will expected a warning message to show for guidance, which is not the case at the momment
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }
        [Test]
        [Given(@"I enter long (.*) in the email")]
        public void GivenIEnterLongInTheEmail(string Username)
        {
            ObjectRepository.driver.FindElement(By.Id("user-identifier-input")).SendKeys(Username);
            Thread.Sleep(1000);
            InSertReportingSteps();


        }
        [Test]
        [Then(@"I should be able to see a warning message displayed in the email section for long username")]
        public void ThenIShouldBeAbleToSeeAWarningMessageDisplayedInTheEmailSectionForLongUsername()
        {
            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.UsernameTooLong).Displayed;
            Assert.True(status); // this test is failing because as a user you will expected a warning message to show for guidance, which is not the case at the momment
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }











    }
}
