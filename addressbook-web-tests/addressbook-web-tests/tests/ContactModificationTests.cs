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
            ContactData newCData = new ContactData("NewFirstName", "NewLastName");
            app.Contact.Modify(newCData);
            app.Auth.Logout();
        }
    }
}
