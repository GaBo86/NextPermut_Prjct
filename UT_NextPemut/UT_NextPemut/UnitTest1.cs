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
    }
}
