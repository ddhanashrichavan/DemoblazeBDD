using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace DemoblazeBDD.PageObjects
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public IWebElement UsernameLogin => Driver.FindElement(By.XPath("//input[@id='loginusername']"));
        public IWebElement PasswordLogin => Driver.FindElement(By.XPath("//input[@id='loginpassword']"));

        public IWebElement UsernameSignin => Driver.FindElement(By.XPath("//input[@id='sign-username']"));
        public IWebElement PasswordSignin => Driver.FindElement(By.XPath("//input[@id='sign-password']"));
        public IWebElement LoginButton => Driver.FindElement(By.XPath("//a[@id='login2']"));
        public IWebElement SigninButton => Driver.FindElement(By.XPath("//a[@id='signin2']"));

        public IWebElement LoginProceed => Driver.FindElement(By.XPath("//button[contains(text(),'Log in')]"));

        public IWebElement SigninProceed => Driver.FindElement(By.CssSelector("#signInModal > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > button:nth-child(2)"));

        public IWebElement LogoutButton => Driver.FindElement(By.XPath("//a[@id='logout2']"));

        public void NavigateToLoginpage()
        {
            Navigate("https://www.demoblaze.com/index.html");
        }

        public IAlert SwitchToAlert()
        {
            return Driver.SwitchTo().Alert();
        }

        public void UntilExistsWait()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
        }

        public void UntilAlertExists()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }

        

        
    }
}
