using May2023.Pages;
using May2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace May2023.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged into Turn Up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new FirefoxDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            Homepage homePageObj = new Homepage();
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new and material record")]
        public void WhenICreateANewAndMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTime(driver);

        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tmPageObj = new TMPage();
            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);

            Assert.AreEqual("May2023", newCode, "Actual Code and expected code do not match.");
            Assert.AreEqual("May2023", newDescription, "Actual Description and expected description do not match.");
            Assert.AreEqual("$12.00", newPrice, "Actual Price and expected price do not match.");
        }

        [When(@"I update '([^']*)', '([^']*)' and '([^']*)' on an existing time and material record")]
        public void WhenIUpdateAndOnAnExistingTimeAndMaterialRecord(string time, string niru, string p2)
        {
            throw new PendingStepException();
        }












    }
}

