using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProjectTest.Support;
using TechTalk.SpecFlow;

namespace DemoblazeBDD.StepDefinitions
{
    [Binding]
    public class LoginTestsSteps
    {
        public string email1;
        public readonly PageFactory _pageFactory;
        public LoginTestsSteps(PageFactory pageFactory) => _pageFactory = pageFactory;

        [Given(@"User open Demoblaze website")]
        public void GivenUserOpenGoDemoblazeWebsite()
        {
            _pageFactory.LoginPage.NavigateToLoginpage();
        }

        [When(@"User clicks Login")]
        public void WhenUserClicksLogin()
        {
            _pageFactory.LoginPage.LoginButton.Click();
        }

        //generate unique email
        public string GenerateUniqueEmail()
        {
            string Month = DateTime.Now.ToString("MMM");
            string Date = DateTime.Now.ToString("dd");
            string year = DateTime.Now.ToString("yyyy");
            DateTime d = DateTime.Now;
            string dateString = d.ToString("yyyyMMddHHmmss");
            string email1 = "ddhanashrichavan+" + dateString + "@gmail.com";
            return this.email1 = email1;


        }
        [When(@"User enters unique username")]
        public void WhenUserEntersUniqueUsername()
        {

            _pageFactory.LoginPage.UsernameSignin.SendKeys(GenerateUniqueEmail());
        }

        [When(@"User enters the password ""([^""]*)""")]
        public void WhenUserEntersThePassword(string Password)
        {
            _pageFactory.LoginPage.PasswordSignin.SendKeys(Password);
        }



        [When(@"User enters the username ""([^""]*)"" and password ""([^""]*)""")]
        public void WhenUserEntersTheUsernameAndPassword(string Username, string Password)
        {
            _pageFactory.LoginPage.UsernameLogin.SendKeys(Username);
            _pageFactory.LoginPage.PasswordLogin.SendKeys(Password);
        }

        [When(@"User enters the signup username ""([^""]*)"" and password ""([^""]*)""")]
        public void WhenUserEntersTheSignupUsernameAndPassword(string Username1, string Password1)
        {
            _pageFactory.LoginPage.UsernameSignin.SendKeys(Username1);
            _pageFactory.LoginPage.PasswordSignin.SendKeys(Password1);
        }

        [When(@"User clicks Proceed login for existing user")]
        public void WhenUserClicksProceedLoginForExistingUser()
        {
            _pageFactory.LoginPage.LoginProceed.Click();
            _pageFactory.LoginPage.UntilExistsWait();
        }


        [When(@"User clicks Proceed login")]
        public void WhenUserClicksProceedLogin()
        {
            _pageFactory.LoginPage.LoginProceed.Click();
            _pageFactory.LoginPage.UntilAlertExists();
        }


        [Then(@"User gets redirected to homepage")]
        public void ThenUserGetsRedirectedToHomepage()
        {
            //IWebElement element = _pageFactory.LoginPage.LogoutButton;
            //String logoutText= element.Text;
            //string actualText1 = "Log out";

            //Assert.That(string.Equals(logoutText,actualText1));

           // Assert.Contains("Log out", _pageFactory.LoginPage..Text.ToString());

            Assert.True(_pageFactory.LoginPage.LogoutButton.Displayed);


        }

        [Then(@"User sees the failed login popup message")]
        public void ThenUserSeesTheFailedLoginPopupMessage()
        {
           IAlert alert= _pageFactory.LoginPage.SwitchToAlert();
            string alertText = alert.Text;
            string[] actualText = { "Wrong password.", "User does not exist.", "Please fill out Username and Password." };

            Assert.That(String.Equals(alertText, actualText[0]) || String.Equals(alertText, actualText[1]) || String.Equals(alertText, actualText[2]));
            alert.Accept();

        }


        [When(@"User clicks Sign Up")]
        public void WhenUserClicksSignUp()
        {
            _pageFactory.LoginPage.SigninButton.Click();
        }

        [When(@"User click on Sign up to proceed")]
        public void WhenUserClickOnSignUpToProceed()
        {
            _pageFactory.LoginPage.SigninProceed.Click();
            _pageFactory.LoginPage.UntilAlertExists();
        }

        [Then(@"User sees the success popup message")]
        public void ThenUserSeesTheSuccessPopupMessage()
        {
            IAlert alert = _pageFactory.LoginPage.SwitchToAlert();
            string alertText = alert.Text;
            string actualText = "Sign up successful.";

            Assert.That(String.Equals(alertText, actualText));
            alert.Accept();
        }

        [Then(@"User sees the failed popup message")]
        public void ThenUserSeesTheFailedPopupMessage()
        {
            IAlert alert = _pageFactory.LoginPage.SwitchToAlert();
            string alertText = alert.Text;
            string[] actualText = { "This user already exist.", "Please fill out Username and Password." };

            Assert.That(String.Equals(alertText, actualText[0]) || String.Equals(alertText, actualText[1]));
            alert.Accept();
        }





    }
}