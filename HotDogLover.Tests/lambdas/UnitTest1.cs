using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HotDogLover.Tests.lambdas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] numbers = new int[] { 10,4,16,7,8,3,6,8,45,2};
            var list = numbers.Take(6).OrderBy(m => m);
           
            Assert.IsNotNull(list);

        }
    }
}
