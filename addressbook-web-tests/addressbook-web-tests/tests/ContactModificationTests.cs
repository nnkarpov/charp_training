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
            if (! app.Contact.IsContactExist())
            {
                ContactData contact = new ContactData("", "");
                app.Contact.Create(contact);
            }
            ContactData newCData = new ContactData("NewFirstName", "NewLastName");
            app.Contact.Modify(newCData);
            app.Auth.Logout();
        }
    }
}
