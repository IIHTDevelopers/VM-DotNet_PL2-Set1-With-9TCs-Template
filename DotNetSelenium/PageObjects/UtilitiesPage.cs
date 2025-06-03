using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace DotNetSelenium.PageObjects
{
    public class UtilitiesPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public UtilitiesPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        // Locators for Utilities Page Elements to be defined here

        /**
        * @Test5
        * @description This method verifies that a warning popup is displayed when attempting to save 
        *              a new Scheme Refund entry without filling any mandatory fields.
        *
        * @expected
        * A warning message should be displayed indicating that mandatory fields must be filled before submission.
        *
        * Steps:
        * 1. Click on the "Utilities" link.
        * 2. Navigate to the "Scheme Refund" tab.
        * 3. If any counter items are available, select the first one.
        * 4. Click on "New Scheme Refund Entry".
        * 5. Click the "Save" button without entering any data.
        * 6. Capture and return the warning message displayed in the popup.
        *
        * @returns The warning message text as a string.
        */
        public String VerifyMandatoryFieldsWarning()
        {
            // Write your logic here
            return null;
        }
    }

}
