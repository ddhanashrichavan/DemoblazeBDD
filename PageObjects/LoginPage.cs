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
        public IWebElement NameOftheUser => Driver.FindElement(By.XPath("//a[@id='nameofuser']"));
        #region Categories
        public IWebElement Categories => Driver.FindElement(By.XPath("//a[@id='cat']"));
        public IWebElement Phones => Driver.FindElement(By.XPath("//div[@id='contcont']//a[text()='Phones']"));
        public IWebElement Samsung_Galaxy_S6 => Driver.FindElement(By.XPath("//a[text()='Samsung galaxy s6']"));
        #endregion
        public IWebElement Add_To_Cart_Button => Driver.FindElement(By.XPath("//a[text()='Add to cart']"));
        public IWebElement Place_Order_Button => Driver.FindElement(By.XPath("//button[text()='Place Order']"));
        public IWebElement Cart_Link => Driver.FindElement(By.XPath("//a[@id='cartur']"));

        #region Place Order

        public IWebElement Name_Input_Textbox => Driver.FindElement(By.XPath("//input[@id='name']"));

        public IWebElement Country_Input_Textbox => Driver.FindElement(By.XPath("//input[@id='country']"));

        public IWebElement City_Input_Textbox => Driver.FindElement(By.XPath("//input[@id='city']"));

        public IWebElement Credit_Card_Input_Textbox => Driver.FindElement(By.XPath("//input[@id='card']"));

        public IWebElement Month_Input_Textbox => Driver.FindElement(By.XPath("//input[@id='month']"));

        public IWebElement Year_Input_Textbox => Driver.FindElement(By.XPath("//input[@id='year']"));

        public IWebElement Purchase_Button => Driver.FindElement(By.XPath("//button[text()='Purchase']"));

        public IWebElement Thank_You_Message => Driver.FindElement(By.XPath("//h2[text()='Thank you for your purchase!']"));

        public IWebElement Details => Driver.FindElement(By.XPath("//p[@class='lead text-muted ']"));

        #endregion



        public void NavigateToLoginpage()
        {
            Navigate("https://www.demoblaze.com/index.html");
        }

        public void Pagerefresh()
        {
            Driver.Navigate().Refresh();
        }


        public void NavigateToNexus6ProductPage()
        {
            Navigate("https://www.demoblaze.com/prod.html?idp_=3");
        }

        public IAlert SwitchToAlert()
        {
            return Driver.SwitchTo().Alert();
        }

        public void UntilExistsWait()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(50));
        }

        public void UntilAlertExists()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }

        public void AfterLoginWait()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//a[@id='nameofuser']")));
        }

        

        
    }
}
