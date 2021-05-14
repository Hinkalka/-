using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Отладчик;
namespace UnitTestProject1
{
    [TestClass]
    
    public class UnitTest1
    {
        g g1 = new Отладчик.g();
        [TestMethod]
        public void TestMethod1()
        {
            int n = 10;
            g1.l(n);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int n = 20;
            g1.l(n);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int n = 30;
            g1.l(n);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int n = 19;
            g1.j(n);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int n = 29;
            g1.j(n);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int n = 39;
            g1.j(n);
        }
    }
}
