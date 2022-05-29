using AventStack.ExtentReports.Gherkin.Model;
using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.Pages
{
    public  class SignIn : Driver 
    {
        private static IWebElement SignInBtn => Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
        public void Login()
        {
            Driver.NavigateUrl();
            SignInBtn.Click();
            Email.SendKeys("flpsilva1992@gmail.com");
            Password.SendKeys("mars447029");
            LoginBtn.Click();
        }
        public void Login2(IWebDriver driver)
        {
            Driver.NavigateUrl();

            //Enter Url
           driver.FindElement(By.XPath("//a[@class='item']")).Click();

            //Enter Username
            driver.FindElement(By.XPath("//input[@placeholder='Email address']")).SendKeys("flpsilva1992@gmail.com");

            //Enter password
            driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys("mars447029");

            //Click on Login Button
            driver.FindElement(By.XPath("//button[@class='fluid ui teal button']")).Click();
            Thread.Sleep(5000);

        }

        public void LoginAssert(IWebDriver driver)
        {
            IWebElement findUsernameOnPage = driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]"));

            Assert.That(findUsernameOnPage.Text, Is.EqualTo("Profile"));
        }
        //public string LoginAssert()
        //{
        //    IWebElement profile = Driver.driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]"));
        //    return profile.Text;

        //}
    }
}