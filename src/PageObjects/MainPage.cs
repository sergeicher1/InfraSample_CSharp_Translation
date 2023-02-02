using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;



namespace InfraSample_CSharp_Translation
{
    internal class MainPage
    {

        [FindsBy(How = How.XPath, Using = "//*[@id=\"hs_menu_wrapper_site_header-module-1_\"]/ul/li[1]/a")]
        public  IWebElement support { get; set; }

        public  IWebElement GetSupport()
        {
            return support;
        }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"hs_menu_wrapper_site_header-module-1_\"]/ul/li[2]/a")]
        public  IWebElement login { get; set; }

        public  IWebElement GetLogin()
        {
            return login;
        }


    }


}
