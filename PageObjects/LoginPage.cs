using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoblazeBDD.PageObjects
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public IWebElement Username => Driver.FindElement(By.XPath("//input[@id='username']"));
        public IWebElement Password => Driver.FindElement(By.XPath("//input[@id='password']"));

        public IWebElement Login_Button => Driver.FindElement(By.XPath("//button[@id='login']"));

        public IWebElement Modules_Dropdown => Driver.FindElement(By.LinkText("Modules"));

        public IWebElement Environment_Dropdown => Driver.FindElement(By.LinkText("Environment"));

        public IWebElement Release_to_water_Text => Driver.FindElement(By.LinkText("Release To Water"));

        public IWebElement New_Record_Button => Driver.FindElement(By.XPath("//a[normalize-space()='New Record']"));

        public IWebElement Description_Field => Driver.FindElement(By.XPath("//textarea[@id='SheReleaseToWater_Description']"));

        public IWebElement Sample_Date_Field => Driver.FindElement(By.XPath("//input[@id='SheReleaseToWater_SampleDate']"));

        public IWebElement Save_and_Close_Button => Driver.FindElement(By.XPath("//button[normalize-space()='Save & Close']"));

        public IWebElement _Button => Driver.FindElement(By.XPath("//button[normalize-space()='Save & Close']"));

        public IWebElement Cog_Button => Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[3]/section[1]/div[4]/div[2]/div[3]/div[2]/button[1]"));

        public IWebElement Cog_Delete => Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[3]/section[1]/div[4]/div[2]/div[3]/div[2]/ul[1]/li[4]/a[1]"));

        public IWebElement Confirm_Button => Driver.FindElement(By.XPath("//button[normalize-space()='Confirm']"));

        public IWebElement Its_a_test_link => Driver.FindElement(By.XPath("(//a[@title='its a test'][normalize-space()='its a test'])[2]"));

        public IWebElement Sample_Date_link => Driver.FindElement(By.LinkText("02/05/2022"));

        public IWebElement Results_are_True_Link => Driver.FindElement(By.XPath("(//a[@title='results are true'][normalize-space()='results are true'])[1]"));

        public IWebElement Date_link => Driver.FindElement(By.XPath("//body/div[@id='main-content']/div[@id='site-wrapper']/section[@role='main']/div[@class='item-box ui-selectable']/div[1]/div[1]/ul[1]/li[3]/a[1]"));

        public IWebElement User_Drop_Down => Driver.FindElement(By.XPath("//a[@title='Pramila Kadam']"));

        public IWebElement Logout_Button => Driver.FindElement(By.XPath("//a[normalize-space()='Log Out']"));

        public void NavigateToLoginpage()
        {
            Navigate("https://stirling.she-development.net/automation");
        }


    }
}
