using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace DotNetSelenium.PageObjects
{
    public class SettingsPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public SettingsPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        // Locators for Settings Page Elements to be defined here
        
        /**
         * @Test9
         * @description This method disables and then re-enables a price category (e.g., "NHIF-1") via the Price Category tab,
         *              verifying that appropriate success messages are displayed for both actions.
         * @expected
         * Success messages "Deactivated." and "Activated." should be displayed after each corresponding action.
         *
         * Steps:
         * 1. Click on the "Settings" link to navigate to the settings module.
         * 2. Click on the "More..." dropdown and select the "Price Category" tab.
         * 3. Click on the "Disable" button for the code "NHIF-1".
         * 4. Verify that the message "Deactivated." appears after disabling.
         * 5. Click on the "Enable" button for the same code.
         * 6. Verify that the message "Activated." appears after enabling.
         *
         * @returns Returns the final activation message if successful; otherwise, the test throws an exception.
         */
        public String TogglePriceCategoryStatus()
        {
        // Write your logic here
            return null;
        }
    }

}
