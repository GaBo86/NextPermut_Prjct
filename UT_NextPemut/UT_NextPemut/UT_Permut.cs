using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UT_NextPemut
{
    [TestClass]
    public class UT_NxtPermut
    {
       [TestMethod]

        public void retur_Numb()
        {
            var permut = new CNxtPermut();
            int[] vector = new int[] {1,2,3};
           
            permut.NextPermutation(vector);
            for (int i=0; i<=vector.Length; i++)
            {
                if (i == 0)
                {
                    Assert.AreEqual(1, vector[i]);
                }
                else if(i == 1)
                {
                    Assert.AreEqual(3, vector[i]);
                }
               else if (i == 2)
                {
                    Assert.AreEqual(2, vector[i]);
                }
            }         
            
        }

        [TestMethod]

        public void retur_NumbCase2()
        {
            var permut = new CNxtPermut();
            int[] vector = new int[] {3,2,1};

            permut.NextPermutation(vector);

            for (int i = 0; i <= vector.Length; i++)
            {
                if (i == 0)
                {
                    Assert.AreEqual(1, vector[i]);
                }
                else if (i == 1)
                {
                    Assert.AreEqual(2, vector[i]);
                }
                else if (i == 2)
                {
                    Assert.AreEqual(3, vector[i]);
                }
            }
           
        }

        [TestMethod]

        public void retur_NumbCase3()
        {
            var permut = new CNxtPermut();
            int[] vector = new int[] {1,1,5};

            permut.NextPermutation(vector);

            for (int i = 0; i <= vector.Length; i++)
            {
                if (i == 0)
                {
                    Assert.AreEqual(1, vector[i]);
                }
                else if (i == 1)
                {
                    Assert.AreEqual(5, vector[i]);
                }
                else if (i == 2)
                {
                    Assert.AreEqual(1, vector[i]);
                }
            }
           
        }

        [TestMethod]

        public void retur_NumbCase4()
        {
            var permut = new CNxtPermut();
            int[] vector = new int[] {1,5};
            string mess = "The vector length value must be greater than two";
            try
            {
                permut.NextPermutation(vector);
            }
            catch(Exception e)
            {
                Assert.Equals(mess, e.Message);
            }


           

        }
    }


}
