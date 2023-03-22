using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UT_NextPemut
{
    [TestClass]
    public class UT_NxtPermut
    {
        [TestMethod]
        public void Return0_Recieve_Empty()
        {
            var permutation = new CNxtPermut();
            int[] pvector= new int[3];
            var result = permutation.get_Vector(pvector);
            Assert.AreEqual(0, result);

;        }

        [TestMethod]

        public void retur_Numb()
        {
            var permut = new CNxtPermut();
            int[] vector = new int[] {1,2,3};
           
            permut.NextPermutation(vector);
            Assert.AreEqual(1, vector[0]);
            Assert.AreEqual(3, vector[1]);
            Assert.AreEqual(2, vector[2]);
            
        }

        [TestMethod]

        public void retur_NumbCase2()
        {
            var permut = new CNxtPermut();
            int[] vector = new int[] {3,2,1};

            permut.NextPermutation(vector);
            Assert.AreEqual(1, vector[0]);
            Assert.AreEqual(2, vector[1]);
            Assert.AreEqual(3, vector[2]);
        }

        [TestMethod]

        public void retur_NumbCase3()
        {
            var permut = new CNxtPermut();
            int[] vector = new int[] {1,1,5};

            permut.NextPermutation(vector);
            Assert.AreEqual(1, vector[0]);
            Assert.AreEqual(5, vector[1]);
            Assert.AreEqual(1, vector[2]);
        }
    }


}
