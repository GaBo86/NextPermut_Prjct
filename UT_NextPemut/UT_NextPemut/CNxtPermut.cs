using System;

namespace UT_NextPemut
{
    internal class CNxtPermut
    {
        public CNxtPermut()
        {
        }

        internal object get_Vector()
        {
            throw new NotImplementedException();
        }

        internal object get_Vector(int[] pvector)
        {
            return 0;
        }

        public  int[] nextPermutation(int[] arr)
        {
            var n = arr.Length;
            int i;
            int j;

            // Find for the pivot element.
            // A pivot is the first element from
            // end of sequencewhich doesn't follow
            // property of non-increasing suffix
            for (i = n - 2; i >= 0; i--)
            {
                if (arr[i] < arr[i + 1])
                {
                    break;
                }
            }

            // Check if pivot is not found
            if (i < 0)
            {
                CNxtPermut.reverse(arr, 0, arr.Length - 1);
                return arr;
            }
            else
            {

                // Find for the successor of pivot in suffix
                for (j = n - 1; j > i; j--)
                {
                    if (arr[j] > arr[i])
                    {
                        break;
                    }
                }

                // Swap the pivot and successor
                CNxtPermut.swap(arr, i, j);

                // Minimise the suffix part
                CNxtPermut.reverse(arr, i + 1, arr.Length - 1);
                return arr;
            }
        }
        public static void reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                CNxtPermut.swap(arr, start, end);
                start++;
                end--;
            }
        }
        public static void swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}