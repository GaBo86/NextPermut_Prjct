using System;

namespace UT_NextPemut
{
    internal class CNxtPermut
    {
        public CNxtPermut()
        {
        }

        public void NextPermutation(int[] nums)
          {
              int n = nums.Length;
            if (n < 2)
                //return;
                throw new  ArgumentException("The vector length value must be greater than two");
                int index = n - 1;
              while (index > 0)
              {
                  if (nums[index - 1] < nums[index])
                      break;
                  index--;
              }
              if (index == 0)
              {
                  reverseSort(nums, 0, n - 1);
                  return;
              }
              else
              {
                  int val = nums[index - 1];
                  int j = n - 1;
                  while (j >= index)
                  {
                      if (nums[j] > val)
                          break;
                      j--;
                  }
                  swap(nums, j, index - 1);
                  reverseSort(nums, index, n - 1);
                  return;
              }

          }
          // swap function
          public void swap(int[] num, int i, int j)
          {
              int temp = 0;
              temp = num[i];
              num[i] = num[j];
              num[j] = temp;
          }
          // using swap function to reverse
          public void reverseSort(int[] num, int start, int end)
          {
              if (start > end)
                  return;
              for (int i = start; i <= (end + start) / 2; i++)
                  swap(num, i, start + end - i);
          }

        public  int[] NextPermutation2(int[] array) 
        {
            int[] result = new int[array.Length];
            Array.Copy(array, result, array.Length);
            int i = result.Length - 2;
            while (i >= 0 && result[i].CompareTo(result[i + 1]) >= 0)
            {
                i--;
            }
            if (i < 0)
            {
                Array.Reverse(result);
                return result;
            }
            int j = result.Length - 1;
            while (result[j].CompareTo(result[i]) <= 0)
            {
                j--;
            }
            int temp = result[i];
            result[i] = result[j];
            result[j] = temp;
            Array.Reverse(result, i + 1, result.Length - i - 1);
            return result;
        }
    }
}