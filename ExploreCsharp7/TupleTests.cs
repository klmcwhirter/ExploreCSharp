using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExploreCsharp7
{
    [TestClass]
    public class TupleTests
    {
        [TestMethod]
        public void TupleAssignmentWithoutNameAreAccessible()
        {
            var t = (1, 2);

            Assert.AreEqual(1, t.Item1, "Item1 should be as defined");
            Assert.AreEqual(2, t.Item2, "Item2 should be as defined");
        }

        [TestMethod]
        public void TupleAssignmentWithNameAreAccessible()
        {
            var t = (a:1, b:2);

            Assert.AreEqual(1, t.a, "a should be as defined");
            Assert.AreEqual(2, t.b, "b should be as defined");
        }

        [TestMethod]
        public void TupleReturnValueAreAccessible()
        {
            var t = SumCount(1, 2);

            Assert.AreEqual(3, t.Item1, "Item1 should be as defined");
            Assert.AreEqual(2, t.Item2, "Item2 should be as defined");
        }

        [TestMethod]
        public void TupleReturnValueWithNamesAreAccessible()
        {
            var t = SumCount(1, 2);

            Assert.AreEqual(3, t.sum, "sum should be as defined");
            Assert.AreEqual(2, t.count, "count should be as defined");
        }

        [TestMethod]
        public void TupleDeconstruct()
        {
            var (sum, count) = SumCount(1, 2);

            Assert.AreEqual(3, sum, "sum should be as defined");
            Assert.AreEqual(2, count, "count should be as defined");
        }

        (int sum, int count) SumCount(params int[] numbers)
        {
            var rc = (sum:0, count:0);
            foreach (var num in numbers)
            {
                rc.sum += num;
                rc.count++;
            }
            return rc;
        }
    }
}
