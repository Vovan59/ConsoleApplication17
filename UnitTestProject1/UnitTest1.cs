using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            int actual = Class1.Factorial(1);
            
            Assert.AreEqual(1, actual);
        }
        [TestMethod]
        public void TestMethod0()
        {

            int actual = Class1.Factorial(0);
            
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {

            int actual = Class1.Factorial(-1);
            
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {

            int actual = Class1.Factorial(10);

            Assert.AreEqual(3628800, actual);
        }



    }
}
