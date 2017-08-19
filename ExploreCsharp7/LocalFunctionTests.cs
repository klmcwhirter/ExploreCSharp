using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExploreCsharp7
{
    [TestClass]
    public class LocalFunctionTests
    {
        [TestMethod]
        public void LocalFunctionReturnsValueUsingLocalVars()
        {
            var numbers = new[] { 1, 2, 3 };

            var (sum, count) = SumCount();

            Assert.AreEqual(6, sum, "sum should be as defined");
            Assert.AreEqual(3, count, "sum should be as defined");

            // Local functions have access to variables in scope - numbers in this case
            (int, int) SumCount()
            {
                var rc = (sum: 0, count: 0);
                Array.ForEach(numbers, (num) => {rc.sum += num; rc.count++; });
                return rc;
            }
        }
    }
}
