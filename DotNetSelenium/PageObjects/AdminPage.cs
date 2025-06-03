using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace DotNetSelenium.PageObjects
{
    public class AdminPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public AdminPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }
        // Locators for Admin dropdown and User Profile page elements to be written here

        /**
        *@Test6
        * Navigates to the "User Profile" page via the Admin dropdown and verifies successful navigation.
        *
        * Steps:
        * 1. Clicks on the Admin dropdown in the header.
        * 2. Selects the "My Profile" option from the dropdown menu.
        * 3. Waits for the User Profile page to load.
        * 4. Retrieves and returns the header text of the User Profile page for validation.
        *
        * @returns The header text from the User Profile page, used to assert successful navigation.
        */
        public String VerifyUserProfileNavigation()
        {
            // Write the required logic here
            return null;
        }
    }

}
