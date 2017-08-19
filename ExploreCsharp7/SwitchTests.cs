using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExploreCsharp7
{
    [TestClass]
    public class SwitchTests
    {
        [TestMethod]
        public void CanDetectCircle()
        {
            var s = new Circle { Radius = 7 };

            var rc = DetectShape(s);

            StringAssert.Contains(rc, "Circle", "Should have detected Circle");
        }

        [TestMethod]
        public void CanDetectRectangle()
        {
            var s = new Rectangle { Height = 14, Length = 7 };

            var rc = DetectShape(s);

            StringAssert.Contains(rc, "rectangle", "Should have detected rectangle");
        }

        [TestMethod]
        public void CanDetectSquare()
        {
            var s = new Rectangle { Height = 7, Length = 7 };

            var rc = DetectShape(s);

            StringAssert.Contains(rc, "square", "Should have detected square");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CanDetectNull()
        {
            Shape s = null;

            var rc = DetectShape(s);

            Assert.Fail("Should have thrown exception");
        }

        [TestMethod]
        public void CanDetectUnsupportedShape()
        {
            var s = new Triangle { Base = 5, Height = 9 };

            var rc = DetectShape(s);

            StringAssert.Contains(rc, "<unknown");
        }

        string DetectShape(Shape shape)
        {
            var rc = string.Empty;

            switch (shape) // Switch on anything
            {
                case Rectangle s when (s.Length == s.Height): // when condition
                    rc = $"{s.Length} x {s.Height} square";
                    break;
                case Rectangle r:
                    rc = $"{r.Length} x {r.Height} rectangle";
                    break;
                case Circle c: // type pattern declaring variable c
                    rc = $"Circle with radius {c.Radius}";
                    break;
                case null: // case with constants as before
                    throw new ArgumentNullException(nameof(shape));
                // case Triangle: - this is purposely missing
                default:
                    rc = "<unknown shape>";
                    break;
            }

            return rc;
        }
    }
}
