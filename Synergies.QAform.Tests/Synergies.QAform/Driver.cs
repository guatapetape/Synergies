using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Synergies.QAform
{
    public class Driver
    {
       public static IWebDriver Instance { get; set; }
        public static void Initialize()
        {
            try
            {
                Instance = new ChromeDriver();
                //Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}