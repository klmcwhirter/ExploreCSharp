using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExploreCsharp6
{
    [TestClass]
    public class StringInterpolationTests
    {
        [TestMethod]
        public void CanUseAsRegularString()
        {
            var s = $"my string";

            Assert.AreEqual("my string", s, "s should act as a regular string");
            Assert.AreEqual(9, s.Length, "s should have length 9");
        }

        [TestMethod]
        public void ShouldReplaceValues()
        {
            var error = "This is some [ERROR]";

            var s = $"An error occurred: {error}";

            StringAssert.Contains(s, "[ERROR]", "Should have replaced the variable for its value");

            // Without the $ no interpolation occurs
            var s2 = "An error occurred: {error}";
            StringAssert.DoesNotMatch(s2, new Regex(".*[ERROR].*"), "Should have NOT replaced the variable for its value");
            StringAssert.Contains(s2, "{error}", "Should have NOT replaced the variable for its value");
        }
    }
}