using InfraSample_CSharp_Translation.src.Utilities;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfraSample_CSharp_Translation
{
    internal class TestCases : CommonOperations
    {

        [Test]
        public void Test1()
        {

            WebFlows.ClickOnSupport();

        }

        [Test]
        public void Test2()
        {
            WebFlows.ClickOnLogin();
        }
    }
}
