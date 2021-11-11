namespace Maximum_subarray_53
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {

            int biggest = nums[0];
            int counter = 0;


            for (int j = 0; j < nums.Length; j++)
            {
                counter = 0;
                for (int i = j; i < nums.Length; i++)
                {
                    counter += nums[i];
                
                    if (biggest < counter)
                    {
                        biggest = counter;
                    }
                }
            }
            

            return biggest;
            
        }
    }
}