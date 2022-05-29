using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1
{
    [Binding]
    public class SellerAddProfileDetailsStepDefinitions : Driver
    {
      
        SignIn signInObj = new SignIn();
        ProfilePage profilePageObj = new ProfilePage();
        SaveScreenShotClass saveScreenShotClassObj = new SaveScreenShotClass();
        [Given(@"I logged into the Mars profile detail page")]
        public void GivenILoggedIntoTheMarsProfileDetailPage()
        {
            Initialize();
            NavigateUrl();
            signInObj.Login();
        }

        [When(@"I add a new skill to the profile details")]
        public void WhenIAddANewSkillToTheProfileDetails()
        {
            profilePageObj.AddNewSkills(driver);
            saveScreenShotClassObj.SaveScreenshot(driver, "ScreenShotFileName");

        }

        [Then(@"the new skill must be visible in my profile details")]
        public void ThenTheNewSkillMustBeVisibleInMyProfileDetails()
        {
            string newSkill = profilePageObj.GetSkill(driver);
            string getExpertOption = profilePageObj.GetSkillLevel(driver);

            Assert.That(newSkill == "Selenium WebDriver", "Actual Skill and expected Skill not do match");
            Assert.That(getExpertOption == "Intermediate", "Actual Option  and expected Option not do match");
        }

        [Given(@"I update Skill on an existing skill record")]
        public void GivenIUpdateSkillOnAnExistingSkillRecord()
        {
           profilePageObj.EditSkill(driver);
            Thread.Sleep(1500);
            saveScreenShotClassObj.SaveScreenshot(driver, "ScreenShotFileName");
        }

        [Then(@"the record should have the updated skill")]
        public void ThenTheRecordShouldHaveTheUpdatedSkill()
        {
            string editedSkill = profilePageObj.GetEditedSkill(driver);
            string editedLevel = profilePageObj.GetEditedLevel(driver);

            Assert.That(editedSkill == "SeleniumEdited", "Actual EditedSkill and expected EditedSkil not do match");
            Assert.That(editedLevel == "Expert", "Actual EditedLevel and expected EditedLevel not do match");
        }

        [Given(@"I delete the skill record")]
        public void GivenIDeleteTheSkillRecord()
        {
            profilePageObj.DeleteSkill(driver);
            Thread.Sleep(1500);
            saveScreenShotClassObj.SaveScreenshot(driver, "ScreenShotFileName");
        }

        [Then(@"I am able to validate that the registered skill was successfully deleted")]
        public void ThenIAmAbleToValidateThatTheRegisteredSkillWasSuccessfullyDeleted()
        {
            string popUpMessage = profilePageObj.DeleteskillAssertion(driver);
            Assert.That(popUpMessage != "SeleniumEdited", "Actual skill not has been deleted");
            driver.Quit();  

        }

    }
}
