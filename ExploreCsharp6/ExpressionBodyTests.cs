using Microsoft.VisualStudio.TestTools.UnitTesting;

using static System.Math;

namespace ExploreCsharp6
{
    [TestClass]
    public class ExpressionBodyTests
    {
        class Circle
        {
            public int Radius { get; set; }

            public double Circumference => 2 * PI * Radius;
        }
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public override string ToString() => $"({X}, {Y})";
        }

        [TestMethod]
        public void ExpressionBodyMethodSimplifiesExpressions()
        {
            var p = new Point { X = 2, Y = 3 };

            var s = p.ToString();

            StringAssert.StartsWith(s, "(2, 3)", "Expression body method should have produced the expected outcome.");
        }

        [TestMethod]
        public void ExpressionBodyPropertiesEaseDeclaration()
        {
            var c = new Circle { Radius = 1 };

            var rc = Abs(6.28318530717959 - c.Circumference) < 0.1;
            Assert.IsTrue(rc, "Property should have produced desired result");
        }
    }
}
