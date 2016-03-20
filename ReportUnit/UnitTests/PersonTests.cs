using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestMethod2()
        {
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod4()
        {
        }

        [TestMethod]
        public void TestMethod5()
        {
        }

        [Ignore]
        [TestMethod]
        public void TestMethod6()
        {
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual("Test", "Fail");
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual("Test", "Fail");
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual("Test", "Fail");

        }


        [ClassCleanup()]
        public static void ReportUnit()
        {

            System.Console.WriteLine("Test");
        }
    }
}
