using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovingTests : TestBase
    {
        [Test]
        public void GroupRemovingTest()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            int id = oldGroups.Count() - 1;
            GroupData toBeRemoved = oldGroups[id];
            app.Groups.Remove(toBeRemoved);
            Assert.AreEqual(oldGroups.Count - 1, app.Groups.GetGroupList().Count());
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Remove(toBeRemoved);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}