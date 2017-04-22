using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("Name", "Header", "Footer");
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Create(group);
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
            app.Auth.Logout();
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("", "", "");
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Create(group);
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
            app.Auth.Logout();
        }
    }
}