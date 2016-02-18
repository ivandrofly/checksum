using Microsoft.VisualStudio.TestTools.UnitTesting;
using Checksum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Checksum.Tests
{
    [TestClass()]
    public class UtilsTests
    {
        [TestMethod()]
        public void CheckRegistryTest1()
        {
            Utils.AddToContextMenu();
            Assert.IsTrue(Registry.ClassesRoot.OpenSubKey("*\\shell\\Checksum") != null);
        }
        [TestMethod()]
        public void CheckRegistryTest2()
        {
            //Assert.IsTrue(Registry.ClassesRoot.OpenSubKey("*\\shell\\Checksum") != null);
            Utils.RemoveFromContextMenu();
            Assert.IsTrue(Registry.ClassesRoot.OpenSubKey("*\\shell\\Checksum") == null);
        }
        // Note: run Visual Studio as admin; CTRL+SHIFT+CLICK
    }
}