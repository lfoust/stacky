using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stacky.IntegrationTests
{
    [TestClass]
    public class PrivilegeTests : IntegrationTest
    {
        [TestMethod]
        public void GetPrivileges()
        {
            var privileges = Client.GetPrivileges();
            Assert.IsTrue(privileges.Count() > 0);
            Assert.IsNotNull(privileges);
        }
    }
}
