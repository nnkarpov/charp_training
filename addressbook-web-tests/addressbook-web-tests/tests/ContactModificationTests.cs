using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            int v = 2;
            app.Contact.ContactExistanceCheck();
            ContactData newCData = new ContactData("NewFirstName", "NewLastName");
            List<ContactData> oldContacts = app.Contact.GetContactList();
            app.Contact.Modify(v, newCData);
            List<ContactData> newContacts = app.Contact.GetContactList();
            oldContacts[v].FirstName = newCData.FirstName;
            oldContacts[v].LastName = newCData.LastName;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
            app.Auth.Logout();
        }
    }
}