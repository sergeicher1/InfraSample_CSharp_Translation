using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraSample_CSharp_Translation
{
    internal class UIActions : CommonOperations
    {

        public static void Click(IWebElement elem)
        {
            //Allure.step("Click on element");
            elem.Click();
        }


        public static void UpdateText(IWebElement elem, String text)
        {
            //Allure.step("Update text");
            elem.SendKeys(text);
        }


        public static void MouseHover(IWebElement elem1)
        {
            //Allure.step("Mouse hover on element");
            actions.MoveToElement(elem1).Perform();
        }

        public static void MouseHoverTwoEls(IWebElement elem1, IWebElement elem2)
        {
            //Allure.step("Mouse hover on element then move to another element");
            actions.MoveToElement(elem1).MoveToElement(elem2).Perform();
        }

        public static void MouseHoverAndClick(IWebElement elem1)
        {
            //Allure.step("Mouse hover and click on element");
            actions.MoveToElement(elem1).Click().Build().Perform();
        }

        public static void MouseHoverTwoElsAndClick(IWebElement elem1, IWebElement elem2)
        {
            //Allure.step("Mouse hover on element then move to another element and click");
            actions.MoveToElement(elem1).MoveToElement(elem2).Click().Build().Perform();
        }


    }
}
