using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ExploreCsharp7
{
    [TestClass]
    public class InlineOutTests
    {
        [TestMethod]
        public void InlineOutIntIsAccessible()
        {
            var s = "12345";
            if (int.TryParse(s, out int i))
            {
                Assert.AreEqual(12345, i, "i should be 12345 and be accessible");
            }
            else
            {
                Assert.Fail("string should have been parsed as int");
            }
        }

        [TestMethod]
        public void InlineOutVarIsAccessible()
        {
            var s = "12345";
            if (int.TryParse(s, out var i)) // use var instead of int
            {
                Assert.AreEqual(12345, i, "i should be 12345 and be accessible");
            }
            else
            {
                Assert.Fail("string should have been parsed as int");
            }
        }

        [TestMethod]
        public void InlineOutVarIsAccessibleOutsideOfIfScope()
        {
            var s = "12345";

            var i = ToInt(s);

            Assert.IsNotNull(i, "i should not be null, but could be");

            Assert.AreEqual(12345, i, "i should be 12345 and be accessible");

            int? ToInt(string num)
            {
                if (!int.TryParse(num, out int val))
                {
                    return null;
                }
                return val; // this would not be possible without adjusted coping rules
            }
        }
    }
}
