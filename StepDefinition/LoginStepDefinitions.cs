using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1
{
    [Binding]
    public class LoginStepDefinitions : Driver
    {
        SignIn signInObj = new SignIn();
        SaveScreenShotClass saveScreenShotClassObj = new SaveScreenShotClass();

        [Given(@"I login to Mars Portal using valid credentials")]
        public void GivenILoginToMarsPortalUsingValidCredentials()
        {
            Initialize();
            NavigateUrl();

            signInObj.Login2(driver);

        }

        [Then(@"I should be able to be logged into the portal successfull")]
        public void ThenIShouldBeAbleToBeLoggedIntoThePortalSuccessfull()
        {
            saveScreenShotClassObj.SaveScreenshot(driver, "ScreenShotFileName");
            signInObj.LoginAssert(driver);
        }

    }
} 
