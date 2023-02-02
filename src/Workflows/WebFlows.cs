using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraSample_CSharp_Translation
{

    internal class WebFlows : CommonOperations
    {

        // TODO: figure out how to implement init all pages 

       

        public static void ClickOnSupport()
        {
            // Initialize page objects
            var main_page = new MainPage();
            PageFactory.InitElements(driver, main_page);

            UIActions.Click(main_page.GetSupport());
            Assert.AreEqual("https://ironscales.com/support/", driver.Url);

        }

        public static void ClickOnLogin()
        {
            var main_page = new MainPage();
            PageFactory.InitElements(driver, main_page);

            UIActions.Click(main_page.GetLogin());
            //main_page.login.Click(); // Also works !!!

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            System.Threading.Thread.Sleep(2000);


            Assert.AreEqual("https://members.ironscales.com/signin/", driver.Url);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }



    }
}
