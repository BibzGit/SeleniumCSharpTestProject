using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpTestProject
{
    public class Tests
    {
        /* public IWebDriver Driver;*/

      //  public WebDriver driver;

     ChromeDriver driver = new ChromeDriver("C:\\Users\\AD731NG\\source\\repos\\SeleniumCSharpTestProject\\SeleniumCSharpTestProject\\Drivers");
        
        [SetUp]
        public void Setup()
        {
          
            System.Console.WriteLine("Setup");


        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            driver.FindElement(By.Id("btnCookie")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
            System.Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}