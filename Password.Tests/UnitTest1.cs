using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Password.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string password = "qwerty12345";
            string expected = "все хорошо";

            //Act
            string actual = Password.CheckPass(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string password = "qwert";
            string expected = "все плохо";

            //Act
            string actual = Password.CheckPass(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
