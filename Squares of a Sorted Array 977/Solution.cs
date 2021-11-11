namespace Squares_of_a_Sorted_Array_977
{
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {

            int[] squaredArray = new int[nums.Length];

            int min = 0;
            int max = nums.Length - 1;
            int i = nums.Length - 1;

            while (min < max && i >= 0)
            {
                int maxSq = nums[max] * nums[max];
                int minSq = nums[min] * nums[min];
                if (maxSq > minSq)
                {
                    squaredArray[i] = maxSq;
                    i--;
                    max--;
                }
                else
                {
                    squaredArray[i] = minSq;
                    i--;
                    min++;
                }
                
            }
            return squaredArray;
        }
    }
}