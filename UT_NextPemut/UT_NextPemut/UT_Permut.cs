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
            int[] outVec;
            int[] compVec = new int[] {1,3,2} ;
            outVec = permut.NextPermutation(vector);
            
            Assert.AreEqual(compVec, vector);
        }

        [TestMethod]

        public void retur_NumbCase2()
        {
            var permut = new CNxtPermut();
            int[] vector = new int[] {3,2,1};
            int[] outVec;
            int[] compVec = new int[] {1,2,3};
            outVec = permut.NextPermutation(vector);

            Assert.AreEqual(compVec, vector);
        }

        [TestMethod]

        public void retur_NumbCase3()
        {
            var permut = new CNxtPermut();
            int[] vector = new int[] {1,1,5};
            int[] outVec;
            int[] compVec = new int[] {1,5,1};
            outVec = permut.NextPermutation(vector);

            Assert.AreEqual(compVec, vector);
        }
    }


}
