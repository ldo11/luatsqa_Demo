using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Demo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Run r = new Run("ee4f7172-9596-11ec-bb26-001a4a250076", "121212");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Run r = new Run("4b7abb94-95a1-11ec-bb26-001a4a250076");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Run r = new Run("214b2963-98a0-11ec-bb26-001a4a250076");
        }
        //12f7d353-98b8-11ec-bb26-001a4a250076
        [TestMethod]
        public void TestMethod4()
        {
            //Run r = new Run("12f7d353-98b8-11ec-bb26-001a4a250076");
            Run r2 = new Run("12f7d353-98b8-11ec-bb26-001a4a250076", "121212");
        }
    }
}
