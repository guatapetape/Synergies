using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Synergies.QAform.Tests
{
   [TestFixture]
    public class FormTests
    {
        [SetUp]
        public void init()
        {
            Driver.Initialize();
        }

        [Test]
        public void CanFillForm_Test()
        {
            Page.Goto();
            Page.Goto_Carrer_And_Apply_Here();
            CreateForm.GotoQA_Automation().AboutYou("FirstName", "MiddleName", "LastName")
                .ContactInfo("Email@email.com", "Email@email.com","000-000-0000")
                .LocationInfo("Street1","Street2","Dominican Republic","Santiago","Santiago","51000")
                .FillFormSynergies();

            
        }

    }
}
