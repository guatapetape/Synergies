using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Synergies.QAform
{
    public class Page
    {
        public static void Goto()
        {
            try
            {
                Driver.Instance.Navigate().GoToUrl("https://synergiesservices.com/");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void Goto_Carrer_And_Apply_Here()
        {
            try
            {
                Driver.Instance.FindElement(By.XPath("//a[contains(text(),'Career')]")).Click();
                Thread.Sleep(3000);
                Driver.Instance.FindElement(By.XPath("//a[contains(text(),'Apply here')]")).Click();
                Thread.Sleep(2000);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        
        

    }
}
