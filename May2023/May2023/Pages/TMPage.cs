using May2023.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2023.Pages
{
    public class TMPage
    {
        public void CreateTime(IWebDriver driver)
        {
            // click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            // select Time from dropdown list
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            // input code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("May2023");

            // input description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("May2023");

            // input price per unit
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("12");

            // click on save button 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            // check if new Time record has been created successfully

            // Navigate to the last page
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 10);

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);

            // Check if record is present in the table
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "May2023")
            {
                Console.WriteLine("Time record created successfully.");
            }
            else
            {
                Console.WriteLine("Time record has not been created successfully.");
            }
        }

        public void EditTM(IWebDriver driver)
        {
            IWebElement Editbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Thread.Sleep(2000);
            Editbtn.Click();
            Thread.Sleep(3000);

            //Edit Code
            IWebElement codetxtboxedit = driver.FindElement(By.Id("Code"));
            codetxtboxedit.Clear();
            Thread.Sleep(1000);
            codetxtboxedit.SendKeys("June2023");
            Thread.Sleep(3000);

            //Edit Description
            IWebElement descriptiontxtboxedit = driver.FindElement(By.Id("Description"));
            descriptiontxtboxedit.Clear();
            descriptiontxtboxedit.SendKeys("June2023");
            Thread.Sleep(3000);

            //Edit Price
            IWebElement pricetxtboxedit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            //pricetxtboxedit.Clear();
            pricetxtboxedit.SendKeys("30");
            Thread.Sleep(2000);

            //Click on Save button
            IWebElement Savebtn = driver.FindElement(By.Id("SaveButton"));
            Savebtn.Click();
            Thread.Sleep(1000);
        }

        public void DeleteTM(IWebDriver driver)
        {
            // code to Delete TM
        }
    }
}
