using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace DemoblazeBDD.PageObjects
{
    public class AboutAndContactUsPage : BasePage
    {
        public AboutAndContactUsPage(IWebDriver driver) : base(driver) { }

        public IWebElement AboutUsBtn => Driver.FindElement(By.XPath("//a[contains(text(),'About us')]"));
        public IWebElement ContactBtn => Driver.FindElement(By.XPath("//a[contains(text(),'Contact')]"));
        public IWebElement PlayVideo => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/form/div/div/button"));
        public IWebElement AboutUsTitle => Driver.FindElement(By.Id("videoModalLabel"));
        public IWebElement CloseBtn => Driver.FindElement(By.XPath("//body/div[@id='videoModal']/div[1]/div[1]/div[3]/button[1]"));
        public IWebElement SendMessageBtn => Driver.FindElement(By.XPath("//button[contains(text(),'Send message')]"));
        public IWebElement ProgressBar => Driver.FindElement(By.XPath("//div[@class='vjs-progress-control vjs-control']"));
        public IWebElement VerifyNewMessageText => Driver.FindElement(By.Id("exampleModalLabel"));
        public IWebElement ContactEmailField => Driver.FindElement(By.Id("recipient-email"));
        public IWebElement ContactNameField => Driver.FindElement(By.XPath("//input[@id='recipient-name']"));
        public IWebElement MessageField => Driver.FindElement(By.XPath("//textarea[@id='message-text']"));


    }
}