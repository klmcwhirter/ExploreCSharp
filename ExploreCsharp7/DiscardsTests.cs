using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ExploreCsharp7
{
    [TestClass]
    public class DiscardsTests
    {
        [TestMethod]
        public void DiscardsAllowEfficientTupleDeconstruction()
        {
            // _ is known as a discard - write only variable whose purpose is shown
            var (_, _, a, _, _, b) = GetTuple();

            Assert.AreEqual(10, a, "a should be 10");
            Assert.AreEqual(11, b, "b should be 11");

            (string, string, int, string, string, int) GetTuple() => (
                    "some text",
                    "some more text",
                    0xA,
                    "another string",
                    "text again",
                    0xB
                );
        }

        [TestMethod]
        public void DiscardsEnableInlineOutVariableTesting()
        {
            var s = "not a number";
            var snum = "12345";

            Assert.IsFalse(IsInt(s), "Should not be recognizable as an int");
            Assert.IsTrue(IsInt(snum), "Should be recognizable as an int");

            // discard in this case simplifies the expression
            bool IsInt(string str) => int.TryParse(str, out _);
        }
    }
}
