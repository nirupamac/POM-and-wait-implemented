using May2023.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;

public class Program
{
    private static void Main(string[] args)
    {
        // open crhome browser
        IWebDriver driver = new ChromeDriver();

        // Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginSteps(driver);

        // Home page object initialization and definition
        Homepage homePageObj = new Homepage();
        homePageObj.GoToTMPage(driver);

        // TM page object initialization and definition
        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateTime(driver);

        // Edit Time record
        tmPageObj.EditTM(driver);

        // Delete Time record
        tmPageObj.DeleteTM(driver);

        

    }
}


