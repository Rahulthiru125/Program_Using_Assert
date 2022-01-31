using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace VProgram
{
      
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            String expected;
            driver.Navigate().GoToUrl("https://www.google.com/");
            expected = driver.Title; 
            Assert.AreEqual("Google",expected );    
        }
        [Test]
        public void Test2()
        {
            String expected1;
            driver.Navigate().GoToUrl("https://www.google.com/");
            expected1 = driver.Title;
            Assert.AreEqual("Facebook", expected1);
        }
        [TearDown]
        public void ExitBrowser()
        {
            Thread.Sleep(6000);
            driver.Quit();
        }

    }
}