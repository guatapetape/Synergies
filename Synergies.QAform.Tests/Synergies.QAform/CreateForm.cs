using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Synergies.QAform
{
    public class CreateForm
    {
        public static FillForm GotoQA_Automation()
        {
            try
            {
                ((IJavaScriptExecutor)Driver.Instance).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                Thread.Sleep(2000);
                Driver.Instance.FindElement(By.XPath("//h4[contains(text(),'Software Developer QA Automation')]")).Click();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            

            return new FillForm();
        }

        public class FillForm
        {
            public string City { get; private set; }
            public string ConfirmEmail { get; private set; }
            public string Country { get; private set; }
            public string Email { get; private set; }
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public string MiddleName { get; private set; }
            public string PhoneNumber { get; private set; }
            public string State { get; private set; }
            public string Street { get; private set; }
            public string Street2 { get; private set; }
            public string ZipCode { get; private set; }

            public FillForm AboutYou(string firstName, string middleName, string lastName)
            {
                this.FirstName = firstName;
                this.MiddleName = middleName;
                this.LastName = lastName;

                return this;
            }

            public FillForm ContactInfo(string email, string confirmEmail, string phoneNumber)
            {
                this.Email = email;
                this.ConfirmEmail = confirmEmail;
                this.PhoneNumber = phoneNumber;
                

                return this;
            }

            public void FillFormSynergies()
            {
                var firstName = Driver.Instance.FindElement(By.CssSelector("input[placeholder='First Name*']"));
                firstName.SendKeys(this.FirstName);
                var middleName = Driver.Instance.FindElement(By.CssSelector("input[placeholder='Initial']"));
                middleName.SendKeys(this.MiddleName);
                var lastName = Driver.Instance.FindElement(By.CssSelector("input[placeholder='Last Name*']"));
                lastName.SendKeys(this.LastName);
                var email = Driver.Instance.FindElement(By.CssSelector("input[placeholder='Email*']"));
                email.SendKeys(this.Email);
                var confirmEmail = Driver.Instance.FindElement(By.CssSelector("input[placeholder='Confirm Email*']"));
                confirmEmail.SendKeys(this.ConfirmEmail);
                var phoneNumber = Driver.Instance.FindElement(By.CssSelector("input[placeholder='Phone Number*']"));
                phoneNumber.SendKeys(this.PhoneNumber);
                var street = Driver.Instance.FindElement(By.CssSelector("input[placeholder='Street Address Line 1*']"));
                street.SendKeys(this.Street);
                var street2 = Driver.Instance.FindElement(By.CssSelector("input[placeholder='Street Address Line 2']"));
                street2.SendKeys(this.Street2);
                SelectElement country = new SelectElement(Driver.Instance.FindElement(By.Name("country_id")));
                country.SelectByText(this.Country);
                var state = Driver.Instance.FindElement(By.Name("state_id"));
                state.Click();
                SelectElement selectState = new SelectElement(state);
                selectState.SelectByText(this.State);
                var city = Driver.Instance.FindElement(By.Name("city"));
                city.SendKeys(this.City);
                var zipCode = Driver.Instance.FindElement(By.CssSelector("input[placeholder='Zip/Postal*']"));
                zipCode.SendKeys(this.ZipCode);
            }

            public FillForm LocationInfo(string street, string street2, string country, string state, string city, string zipCode)
            {
                this.Street = street;
                this.Street2 = street2;
                this.Country = country;
                this.State = state;
                this.City = city;
                this.ZipCode = zipCode;

                return this;
            }
        }
    }
}
