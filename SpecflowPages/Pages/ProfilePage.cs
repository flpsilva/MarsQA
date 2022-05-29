
using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Threading;

using OpenQA.Selenium.Support.Events;
using System;
using System.IO;
using NUnit.Framework;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class ProfilePage : Driver
    {

        IWebElement skillsTab = driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
        public void AddNewSkills(IWebDriver driver)
        {
            //select skill tab
            IWebElement skillsTab = driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
            skillsTab.Click();
            //Add new skills
            IWebElement addNewSkillBtn = driver.FindElement(By.XPath("//div//div//div//div//div//div//div[3]//div[1]//div[2]//div[1]//table[1]//thead[1]//th[3]//div"));
            addNewSkillBtn.Click();
            //idenify the skill textbox and input a language
            IWebElement skillTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            skillTextbox.Click();
            skillTextbox.SendKeys("Selenium WebDriver");
            Thread.Sleep(2000);
            //Select Level from Skill Level dropdown
            IWebElement skillDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
            skillDropdown.Click();

            IWebElement ExpertOpt = driver.FindElement(By.XPath("//option[@value='Intermediate']"));
            ExpertOpt.Click();
            Thread.Sleep(2000);
            IWebElement AddBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddBtn.Click();
            Thread.Sleep(2000);
            // Call take screenshot function
        }

       
        public string GetSkill(IWebDriver driver)
        {
            IWebElement actualSkill = driver.FindElement(By.XPath("//tbody//tr//td[1]"));
            return actualSkill.Text;
        }

        public string GetSkillLevel(IWebDriver driver)
        {
            IWebElement actualSkillLevel = driver.FindElement(By.XPath("//tbody//tr//td[2]"));
            return actualSkillLevel.Text;
        }

        public void EditSkill(IWebDriver driver)
        {
            skillsTab.Click();
            //go to Edit Icon Button
            IWebElement editBtn = driver.FindElement(By.XPath("//tbody/tr/td[3]/span[1]"));
            Thread.Sleep(2000);
            editBtn.Click();
            IWebElement editSkillTextbox = driver.FindElement(By.XPath("//td//div//div[1]//input"));
            editSkillTextbox.Clear();
            editSkillTextbox.SendKeys("SeleniumEdited");
            IWebElement editLevelBtn = driver.FindElement(By.XPath("//td//div//div[2]//select"));
            editLevelBtn.Click();
            //select level expert
            driver.FindElement(By.XPath("//td//div//div[2]//select//option[4]")).Click();
            IWebElement updateBtn = driver.FindElement(By.XPath("//td//span//input[@value='Update']"));
            updateBtn.Click();
            //Thread.Sleep(3000);


        }

        public string GetEditedSkill(IWebDriver driver)
        {
            IWebElement editedSkill = driver.FindElement(By.XPath("//tbody//tr//td[1]"));
            return editedSkill.Text;
        }

        public string GetEditedLevel(IWebDriver driver)
        {
            IWebElement editedLevel = driver.FindElement(By.XPath("//tbody//tr//td[2]"));
            return editedLevel.Text;

        }

        public void DeleteSkill(IWebDriver driver)
        {
            skillsTab.Click();
            IWebElement deleteBtn = driver.FindElement(By.XPath("//tbody//tr//td[3]//span[2]//i"));
            deleteBtn.Click();
     
        }
        
        public string DeleteskillAssertion(IWebDriver driver)  
        {   
            //pop delete skill assertion
            IWebElement popUpdeleteMessage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div"));
            return popUpdeleteMessage.Text;
        }

        //public void ShareSkill(IWebDriver driver)
        //{
        //    //click on share skill button
        //    IWebElement ShareSkillBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[1]/div/div[2]/a"));
        //    ShareSkillBtn.Click();

        //    //type the title
        //    IWebElement TitleTextbox = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
        //    TitleTextbox.Click();
        //    TitleTextbox.SendKeys("");

        //    //Write a description
        //    IWebElement DescriptionTextbox = driver.FindElement(By.XPath("//*[@id=service - listing - section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
        //    DescriptionTextbox.Click(); 
        //    DescriptionTextbox.SendKeys("");

        //    //Choose a category services
        //    IWebElement CategoryDropdown = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[3]/div[2]/div/div/select"));
        //    CategoryDropdown.Click();
        //    IWebElement ProgrammingTechOption = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]"));
        //    ProgrammingTechOption.Click();
        //    IWebElement CategoryDropdown2 = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
        //    CategoryDropdown2.Click();
        //    IWebElement QAOption = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]"));
        //    QAOption.Click();

        //    //Choose tags services
        //    IWebElement TagTextbox = driver.FindElement(By.XPath("//*[@id='service - listing - section]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        //    TagTextbox.Click();
        //    TagTextbox.SendKeys("QA");
        //    //TagTextbox.Submit();

        //    //Service Type
        //    IWebElement TypeCheckbox = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
        //    TypeCheckbox.Click();

        //    //Location Type
        //    IWebElement LocatitonCheckbox = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
        //    LocatitonCheckbox.Click();

        //    //Available days
        //    IWebElement AvailableDayCheckbox = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
        //    AvailableDayCheckbox.Click();
        //    IWebElement AvailableDayCheckbox2 = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input"));
        //    AvailableDayCheckbox2.Click();

        //    //Skill Trade checkbox
        //    IWebElement Creditcheckbox = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
        //    Creditcheckbox.Click();

        //    //Credit Value
        //    IWebElement Valuecheckbox = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[8]/div[4]/div/div/input"));
        //    Valuecheckbox.Click();
        //    Valuecheckbox.SendKeys("9");

        //    //Active service
        //    IWebElement ActiveCheckbox = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
        //    ActiveCheckbox.Click();

        //    // click on save button
        //    IWebElement SaveBtn = driver.FindElement(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[11]/div/input[1]"));
        //    SaveBtn.Click();
        //}


    }
}

