using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.IO;
using Newtonsoft.Json.Linq;
using DotNetSelenium.Utilities;

namespace DotNetSelenium.PageObjects
{
    public class IncentivePage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public IncentivePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        // Write the required Locators for Incentive Page Elements

        /**
        *@Test8
@description : Edits the TDS percentage for a specific employee and verifies that the updated value is reflected in the UI.
         *
         * Steps:
         * 1. Reads the employee name from a JSON test data file.
         * 2. Navigates to the Incentive module and selects the Settings tab.
         * 3. Searches for the employee using the search bar.
         * 4. Clicks the "Edit TDS%" button to open the TDS input modal.
         * 5. Clears the existing value and enters a new random TDS percentage.
         * 6. Clicks the "Update TDS" button to save changes.
         * 7. Repeats the search and retrieves the updated TDS value from the table.
         * 8. Verifies that the displayed TDS value matches the newly entered value.
         *
         * @returns : True if the updated TDS percentage is correctly reflected; otherwise, throws an exception.
         */
        public bool EditTDSForEmployee()
        {
            // Write your logic here
            return false;
        }
    }
}
