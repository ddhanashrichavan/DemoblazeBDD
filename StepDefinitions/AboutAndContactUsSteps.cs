using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProjectTest.Support;
using TechTalk.SpecFlow;

namespace DemoblazeBDD.StepDefinitions
{
    [Binding]
    public class AboutandContactUsSteps
    {
        public readonly PageFactory _pageFactory;
        public AboutandContactUsSteps(PageFactory pageFactory) => _pageFactory = pageFactory;

        [When(@"User clicks about us on navigation bar")]
        public void WhenUserClicksAboutUsOnNavigationBar()
        {
            _pageFactory.AboutAndContactUsPage.AboutUsBtn.Click();
           _pageFactory.LoginPage.UntilExistsWait();

        }

        [Then(@"About us Popup appears")]
        public void ThenAboutUsPopupAppears()
        {
            
            Assert.True(_pageFactory.AboutAndContactUsPage.AboutUsTitle.Displayed);
        }

        [When(@"user clicks on play button")]
        public void WhenUserClicksOnPlayButton()
        {
            _pageFactory.AboutAndContactUsPage.PlayVideo.Click();
        }

        [Then(@"the video starts playing")]
        public void ThenTheVideoStartsPlaying()
        {
            Assert.True(_pageFactory.AboutAndContactUsPage.ProgressBar.Displayed);
        }

        [Then(@"user clicks on close button")]
        public void ThenUserClicksOnCloseButton()
        {
            _pageFactory.AboutAndContactUsPage.CloseBtn.Click();
        }

        [When(@"User clicks contact on navigation bar")]
        public void WhenUserClicksContactOnNavigationBar()
        {
            _pageFactory.AboutAndContactUsPage.ContactBtn.Click();
        }

        [Then(@"contact Popup appears")]
        public void ThenContactPopupAppears()
        {
            Assert.True(_pageFactory.AboutAndContactUsPage.VerifyNewMessageText.Displayed);
        }

        [When(@"user enters information '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenUserEntersInformation(string p0, string p1, string p2)
        {
            _pageFactory.AboutAndContactUsPage.ContactEmailField.SendKeys(p0);
            _pageFactory.AboutAndContactUsPage.ContactNameField.SendKeys(p1);
            _pageFactory.AboutAndContactUsPage.MessageField.SendKeys(p2);

        }

        [When(@"user clicks on Send Message")]
        public void WhenUserClicksOnSendMessage()
        {
            _pageFactory.AboutAndContactUsPage.SendMessageBtn.Click();
            _pageFactory.LoginPage.UntilAlertExists();

        }

        [Then(@"Alert appears with text ""([^""]*)""")]
        public void ThenAlertAppearsWithText(string p0)
        {
            IAlert alert = _pageFactory.LoginPage.SwitchToAlert();
            string alertText = alert.Text;
            string actualText = "Thanks for the message!!";
            Assert.That(String.Equals(alertText, actualText));
            alert.Accept();

        }


    }

}

