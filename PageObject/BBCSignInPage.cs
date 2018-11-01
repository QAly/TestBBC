using BDDProject.ComponentHelper;
using BDDProject.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDProject.PageObject
{
    public class BBCSignInPage
    {
        #region WebElement
        public By EmailBox = By.Id("user-identifier-input");
        public By UsernameBox = By.Id("user-identifier-input");
        public By PasswordBox = By.Id("password-input");
        public By SignInButton = By.Id("submit-button");
        public By AccountLocked = By.XPath("//*[@id='container']/descendant::span[text()='Sorry, your account is locked']");
        public By Register = By.XPath(".//*[@id='container']/descendant::span[text()='Let’s start. This account is for someone who is...']");
        public By Accountusage = By.XPath(".//*[@id='orb-modules']/descendant::a[text()='Creating & Using Your Account']");
        public By NeedHelp = By.XPath(".//*[@id='container']/descendant::span[text()='Need help signing in?']");
        public By Privacy = By.XPath(".//*[@id='orb-modules']/descendant::a[text()='Your Information & Privacy']");
        public By Cookies = By.XPath(".//*[@id='orb-modules']/descendant::a[text()='Cookie & Browser Settings']");
        public By Accessibility = By.XPath(".//*[@id='header']/span");
        public By PGuidance = By.XPath(".//*[@id='main']/descendant::strong[text()='Parental Controls']");
        public By CloseButton = By.XPath(".//*[@id='signin-page']/a");
        public By ProperEmail = By.XPath(".//*[@id='form-message-username']/descendant:: span[4]");
        public By AccountNotLinkToBBC = By.XPath(".//*[@id='form-message-username']/descendant::a[text()='register for a new account']");
        public By AcceptableCharacters = By.XPath(".//*[@id='form-message-username']/p/span/span");
        public By UnacceptableCharacters = By.XPath(".//*[@id='form-message-username']/p/span/span");
        public By ShowWarningMessageEmailNoValid = By.XPath(".//*[@id='form-message-username']/p/span/span[3]");
        public By ShortPassword = By.XPath(".//*[@id='form-message-password']/p/span/span[text()='Sorry, that password is too short']");
        public By PasswordToContainLetter = By.XPath(" .//*[@id='form-message-password']/p/span");
        public By PasswordToContainCharacters = By.XPath(" .//*[@id='form-message-password']/p/span");
        public By UsernameTooLong = By.XPath(".//*[@id='form-message-username']/p/span");
        public By AccountDisplayed = By.XPath(".//*[@id='idcta-link']");

        #endregion

        #region Actions
        public  void ClickontSignInButton()
        {

            ObjectRepository.driver.FindElement(SignInButton).Click();
        }

        public void InputEmail()
        {

            ObjectRepository.driver.FindElement(EmailBox).SendKeys(ObjectRepository.config.GetEmail());
        }

        public void InputUsername()
        {

            ObjectRepository.driver.FindElement(UsernameBox).SendKeys(ObjectRepository.config.GetUsername());
        }

        public void InputPassword()
        {
            ObjectRepository.driver.FindElement(PasswordBox).Clear();
            Thread.Sleep(1000);
            ObjectRepository.driver.FindElement(PasswordBox).SendKeys(ObjectRepository.config.GetPassword());
            //string title = ObjectRepository.driver.Title;
        }

        

        #endregion




    }
}
