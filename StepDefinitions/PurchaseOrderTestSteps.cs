using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProjectTest.Support;
using TechTalk.SpecFlow;

namespace DemoblazeBDD.StepDefinitions
{
    [Binding]
    public class PurchaseOrderTestSteps
    {
        public readonly PageFactory _pageFactory;
        public PurchaseOrderTestSteps(PageFactory pageFactory) => _pageFactory = pageFactory;

        [Then(@"User navigate to Categories ->Phones")]
        public void ThenUserNavigateToCategories_Phones()
        {
            _pageFactory.LoginPage.Categories.Click();
            _pageFactory.LoginPage.Phones.Click();
        }

        [Then(@"User click on Samsung galaxy s(.*)")]
        public void ThenUserClickOnSamsungGalaxyS(int p0)
        {
            _pageFactory.LoginPage.Samsung_Galaxy_S6.Click();

        }

        [Then(@"User click on Add to cart button")]
        public void ThenUserClickOnAddToCartButton()
        {
            _pageFactory.LoginPage.Add_To_Cart_Button.Click();
            _pageFactory.LoginPage.UntilAlertExists();

        }

        [Then(@"User verify that product is added")]
        public void ThenUserVerifyThatProductIsAdded()
        {
            IAlert alert = _pageFactory.LoginPage.SwitchToAlert();
            string alertText = alert.Text;
            string actualText = "Product added.";

            Assert.That(String.Equals(alertText, actualText));
            alert.Accept();

        }

        [Then(@"User navigate to Cart")]
        public void ThenUserNavigateToCart()
        {
            _pageFactory.LoginPage.Cart_Link.Click();
        }

        [Then(@"User click on Place order")]
        public void ThenUserClickOnPlaceOrder()
        {
            _pageFactory.LoginPage.Place_Order_Button.Click();
        }

        [Then(@"User fill the form with fields '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)' and submit")]
        public void ThenUserFillTheFormWithFieldsAndSubmit(string name, string country, string city, string cardNumber, string month, string year)
        {
            _pageFactory.LoginPage.Name_Input_Textbox.SendKeys(name);
            _pageFactory.LoginPage.Country_Input_Textbox.SendKeys(country);
            _pageFactory.LoginPage.City_Input_Textbox.SendKeys(city);
            _pageFactory.LoginPage.Credit_Card_Input_Textbox.SendKeys(cardNumber);
            _pageFactory.LoginPage.Month_Input_Textbox.SendKeys(month);
            _pageFactory.LoginPage.Year_Input_Textbox.SendKeys(year);

            _pageFactory.LoginPage.Purchase_Button.Click();
        }

        [Then(@"User verify that order has placed")]
        public void ThenUserVerifyThatOrderHasPlaced()
        {
            Assert.True(_pageFactory.LoginPage.Thank_You_Message.Displayed);
            //Assert.Contains("Dhana", _pageFactory.LoginPage.Details.Text.ToString());
            //Assert.Contains("3456782978", _pageFactory.LoginPage.Details.Text.ToString());
        }

        [Then(@"User open product Nexus (.*) in new window")]
        public void ThenUserOpenProductNexusInNewWindow(int p0)
        {
            string originalWindow = _pageFactory.Driver.CurrentWindowHandle;
            _pageFactory.Driver.SwitchTo().NewWindow(WindowType.Window);

            _pageFactory.LoginPage.NavigateToNexus6ProductPage();

            _pageFactory.Driver.SwitchTo().Window(_pageFactory.Driver.WindowHandles[1]);
            _pageFactory.Driver.Close();
            _pageFactory.Driver.SwitchTo().Window(originalWindow);
        }


    }
}
