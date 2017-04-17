using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            app.Groups.GroupExistenceCheck();
            GroupData newData = new GroupData("NewName", "NewHeader", "NewFooter");
            app.Groups.Modify(1, newData);
            app.Auth.Logout();
        }
    }
}