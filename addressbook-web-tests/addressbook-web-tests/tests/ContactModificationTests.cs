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
            List<ContactData> oldContacts = ContactData.GetAll();
            ContactData oldCData = oldContacts[0];
            app.Contact.Modify(oldCData, newCData);
            Assert.AreEqual(oldContacts.Count, app.Contact.GetContactCount());
            List<ContactData> newContacts = ContactData.GetAll();
            oldContacts[0].FirstName = newCData.FirstName;
            oldContacts[0].LastName = newCData.LastName;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
            foreach (ContactData contact in newContacts)
            {
                if (contact.Id == oldCData.Id)
                {
                    Assert.AreEqual(newCData.FirstName, contact.FirstName);
                    Assert.AreEqual(newCData.LastName, contact.LastName);
                }
            }
            app.Auth.Logout();
        }
    }
}