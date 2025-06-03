using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace DotNetSelenium.PageObjects
{
    public class AppointmentPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public AppointmentPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        // Locators for Appointment Page Elements

/**
 * @Test1
 * Selects "New Patient" from the Visit Type dropdown and verifies that all results reflect "New Visit" in the Visit Type column.
 *
 * Steps:
 * 1. Clicks on the Appointment link and selects the first available counter item (if present).
 * 2. Navigates to the Appointment Booking List page.
 * 3. Selects "New Patient" from the Visit Type dropdown.
 * 4. Sets the From Date to "01-01-2024" to filter results.
 * 5. Clicks the "Show Patient" button to retrieve appointment data.
 * 6. Validates that the Visit Type column displays only "New Visit" entries.
 *
 * @returns True if all entries in the Visit Type column contain "New"; otherwise, returns false.
 */
        public bool VerifyVisitTypeDropdown()
        {
            // Write your logic here
            return false;
        }
    }
}
