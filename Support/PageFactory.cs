using OpenQA.Selenium;
using DemoblazeBDD.Drivers;
using DemoblazeBDD.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProjectTest.Support
{
    public class PageFactory
    {

        public PageFactory()
        {
            Driver = new Driver().Current;
            LoginPage = new LoginPage(Driver);
            AboutAndContactUsPage = new AboutAndContactUsPage(Driver);
            Driver.Manage().Window.Maximize();
        }

        public IWebDriver Driver { get; }
        public LoginPage LoginPage { get; }

        public AboutAndContactUsPage AboutAndContactUsPage { get; }

    }
}
