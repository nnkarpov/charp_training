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
            app.Contact.ContactExistanceCheck();
            ContactData newCData = new ContactData("NewFirstName", "NewLastName");
            List<ContactData> oldContacts = app.Contact.GetContactList();
            app.Contact.Modify(0, newCData);
            List<ContactData> newContacts = app.Contact.GetContactList();
            oldContacts[0].FirstName = newCData.FirstName;
            oldContacts[0].LastName = newCData.LastName;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
            app.Auth.Logout();
        }
    }
}