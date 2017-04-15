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
            if (! app.Contact.IsContactExist())
            {
                ContactData contact = new ContactData("", "");
                app.Contact.Create(contact);
            }
            app.Contact.Remove(1);
            app.Auth.Logout();
        }
    }
}
