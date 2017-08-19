using Microsoft.VisualStudio.TestTools.UnitTesting;

using static System.Math;

namespace ExploreCsharp6
{
    [TestClass]
    public class StaticUsingsTests
    {
        [TestMethod]
        public void CanUseStaticUsing()
        {
            var n = 4;

            var rc = Sqrt(n);

            Assert.AreEqual(2, rc, "Sqrt of 4 should be 2");
        }
    }
}
