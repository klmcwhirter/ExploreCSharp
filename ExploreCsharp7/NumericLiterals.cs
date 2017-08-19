using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExploreCsharp.Tests
{
    [TestClass]
    public class NumericLiterals
    {
        [TestMethod]
        public void BinaryLiteralHasCorrectValue()
        {
            var b = 0b101;

            Assert.AreEqual(5, b, "b should have value 5");
        }

        [TestMethod]
        public void BinaryLiteralWithSeparatorsHasCorrectValue()
        {
            var b = 0b1010_1010;

            Assert.AreEqual(170, b, "b should have value 170");
        }

        [TestMethod]
        public void DecimalLiteralWithSeparatorsHasCorrectValue()
        {
            var b = 1_234_567_890;

            Assert.AreEqual(1234567890, b, "b should have value 1234567890");
        }

        [TestMethod]
        public void HexLiteralWithSeparatorsHasCorrectValue()
        {
            var b = 0xDEAD_BEEF;

            Assert.AreEqual(3735928559, b, "b should have value ‭3735928559‬");
        }
    }
}
