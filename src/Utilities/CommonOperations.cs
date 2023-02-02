using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net;
using System.Threading;
using System.Xml.Linq;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using SeleniumExtras.PageObjects;
using InfraSample_CSharp_Translation.src.Utilities;

namespace InfraSample_CSharp_Translation

{

    internal class CommonOperations : BaseVariables
    {
        static string data_path = "D:\\VisualStudio\\InfraSample_CSharp_Translation\\src\\Configuration\\data.xml";

        public static void InitWebBrowser() // TODO: Add browsers
        {

            
            driver = GetChrome();

            //driver = GetFirefox();
            //driver = GetMSEdge();
            //actions = new Actions(driver);
        }

        public static WebDriver GetChrome()
        {
            Console.WriteLine("Used chrome driver");
            return new ChromeDriver();
        }

        public static WebDriver GetFirefox()
        {
            Console.WriteLine("Used firefox driver");
            return new FirefoxDriver();
        }
        public static WebDriver GetMSEdge()
        {
            Console.WriteLine("Used ms edge driver");
            return new EdgeDriver();
        }

        [SetUp]
        public void Start()
        {
            Console.WriteLine("\nTest case started!\n");
            InitWebBrowser();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ironscales.com/");

        }

        [TearDown]
        public void Close()
        {
            Thread.Sleep(1000);
            driver.Quit();
            Console.WriteLine("\nTest case completed!\n");


        }

        // TODO: Add Allure reports
    }
}
