using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            int v = 0;
            app.Contact.ContactExistanceCheck();
            List<ContactData> oldContacts = app.Contact.GetContactList();
            app.Contact.Remove(v);
            List<ContactData> newContacts = app.Contact.GetContactList();
            oldContacts.RemoveAt(v);
            Assert.AreEqual(oldContacts, newContacts);
            app.Auth.Logout();
        }
    }
}