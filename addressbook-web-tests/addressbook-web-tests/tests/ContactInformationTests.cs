using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactInformationTests : AuthTestBase
    {
        [Test]
        public void TestContactInformation()
        {
            int v = 0;
            ContactData fromTable = app.Contact.GetContactInformationFromTable(v);
            ContactData fromForm = app.Contact.GetContactInformationFromEditForm(v);
            Assert.AreEqual(fromTable, fromForm);
            Assert.AreEqual(fromTable.Address, fromForm.Address);
            Assert.AreEqual(fromTable.AllPhones, fromForm.AllPhones);
        }

        [Test]
        public void TestContactInformationReverse()
        {
            int v = 0;
            string fromTableReverse = app.Contact.GetContactInformationFromTableReverse(v);
            string fromFormReverse = app.Contact.GetContactInformationFromEditFormReverse(v);
            Assert.AreEqual(fromTableReverse, fromFormReverse);
        }
    }
}