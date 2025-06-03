using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.IO;

namespace DotNetSelenium.PageObjects
{
    public class PatientPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public PatientPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        // Locators for Patient Page Elements to be defined here
/**
 * @Test7
 * @description : This method uploads a profile picture for a patient by navigating to the "Register Patient" tab
 *              and completing the image upload workflow.
 * @expected : The uploaded profile image should be visible on the patient registration screen, confirming success.
 *
 * Steps:
 * 1. Click on the "Patient" link from the navigation menu.
 * 2. Select the "Register Patient" tab to open the registration section.
 * 3. Click on the profile picture icon followed by the "New Photo" button.
 * 4. Upload a test image from the predefined directory.
 * 5. Wait for the image to upload and click the "Done" button to finalize.
 * 6. Verify that the uploaded image is displayed on the UI.
 *
 * @returns : True if the image is displayed after upload; otherwise, throws an exception.
 */
        public bool UploadProfilePicture()
        {
            // Write your logic here
            return false;
        }
    }
}
