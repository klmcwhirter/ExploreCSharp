using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExploreCsharp6
{
    [TestClass]
    public class GetterAutoPropertiesTests
    {
        class Point
        {
            public int X { get; }
            public int Y { get; }
            public Point(int x, int y) { X = x; Y = y; }
        }

        public int X { get; } = 5;
        public int Y { get; }

        [TestMethod]
        public void CanAssign()
        {
            Assert.AreEqual(5, X, "X should have the value 5");
        }

        [TestMethod]
        public void PropertyWithNoSetterIsSetToDefault()
        {
            Assert.AreEqual(default(int), Y, "Y should have the default value of 0");
        }

        [TestMethod]
        public void PropertyWithNoSetterCanBeSetInCtor()
        {
            var p = new Point(2,3);

            Assert.AreEqual(2, p.X, "p.X should have the default value of 2");
            Assert.AreEqual(3, p.Y, "p.Y should have the default value of 3");
        }
    }
}
