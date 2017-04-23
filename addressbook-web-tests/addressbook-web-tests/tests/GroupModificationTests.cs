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
            int v = 0;
            app.Groups.GroupExistenceCheck();
            GroupData newData = new GroupData("NewName", "NewHeader", "NewFooter");
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            GroupData oldData = oldGroups[v];
            app.Groups.Modify(v, newData);
            Assert.AreEqual(oldGroups.Count, app.Groups.GetGroupCount());
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[v].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
            foreach (GroupData group in newGroups)
            {
                if (group.Id == oldData.Id)
                {
                    Assert.AreEqual(newData.Name, group.Name);
                }
            }
            app.Auth.Logout();
        }
    }
}