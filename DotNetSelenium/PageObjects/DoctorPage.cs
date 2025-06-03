using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading;
using DotNetSelenium.Utilities;

namespace DotNetSelenium.PageObjects
{
    public class DoctorPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private JObject testData;

        public DoctorPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        // Write the required Locators here

        /**
        * @Test3
        * @description Searches for a specific patient in the In-Patient list and verifies that their overview page is displayed.
        *
        * Steps:
        * 1. Reads the patient name from a JSON test data file.
        * 2. Clicks on the Doctor module and navigates to the In-Patient tab.
        * 3. Locates the appropriate search box and enters the patient name.
        * 4. Waits briefly and clicks the preview icon from the Actions column.
        * 5. Retrieves and returns the patient name heading from the overview page for validation.
        *
        * @returns The patient name displayed on the overview page, converted to lowercase and trimmed.
        */
        public String VerifyPatientOverview()
        {
            // Write your logic here
            return null;
        }
    }
}
