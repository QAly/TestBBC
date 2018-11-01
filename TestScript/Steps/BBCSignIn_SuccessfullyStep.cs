using BDDProject.PageObject;
using BDDProject.Settings;
using BDDProject.TestBaseClass;
using NUnit.Framework;
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
        [Then(@"I should be redirected to BBC account page veryfy by registred username diplayed")]
        public void ThenIShouldBeRedirectedToBBCAccountPageVeryfyByRegistredUsernameDiplayed()
        {

            BBCSignInPage page = new BBCSignInPage();
            bool status = ObjectRepository.driver.FindElement(page.AcceptableCharacters).Displayed;
            Assert.True(status);
            Thread.Sleep(1000);
            InSertReportingSteps();
            Thread.Sleep(1000);
            TearDownReport();

        }



    }
}
