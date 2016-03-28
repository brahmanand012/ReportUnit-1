using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void NUnitTest1()
        {
        }

        [Test]
        public void NUnitTest2()
        {
            NUnit.Framework.Assert.IsTrue(false);
        }
    }
}
