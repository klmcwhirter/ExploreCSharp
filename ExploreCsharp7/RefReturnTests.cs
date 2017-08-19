using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExploreCsharp.Tests
{
    [TestClass]
    public class RefReturnTests
    {
        int[,] Matrix = new[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        [TestMethod]
        public void RefReturnWithRefVarAllowsRefModify()
        {
            ref var item = ref Find(Matrix, (val) => val == 5);
            Assert.AreEqual(5, item, "at this point item is 5");

            item = 24;
            Assert.AreEqual(24, Matrix[1, 1], "Matrix[1,1] should have been modified to 24 via ref");


            ref int Find(int[,] matrix, Func<int, bool> predicate)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        if (predicate(matrix[i, j]))
                            return ref matrix[i, j];
                throw new InvalidOperationException("Not found");
            }
        }

        [TestMethod]
        public void RefReturnWithoutRefVarDoesNotModify()
        {
            var item = Find(Matrix, (val) => val == 5);
            Assert.AreEqual(5, item, "at this point item is 5");

            item = 24;
            Assert.AreEqual(5, Matrix[1, 1], "Matrix[1,1] should NOT have been modified to 24");

            // Same as above
            ref int Find(int[,] matrix, Func<int, bool> predicate)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        if (predicate(matrix[i, j]))
                            return ref matrix[i, j];
                throw new InvalidOperationException("Not found");
            }
        }

    }
}
