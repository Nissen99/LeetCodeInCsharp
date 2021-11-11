namespace Rotate_Array_189
{
    public class Solution
    {
        public void Rotate(int[] nums, int k) {

            if (nums.Length == 1)
            {
                return;
            }
            for (int j = 0; j < k; j++)
            {
                int preserve = nums[nums.Length-1];
                for (int i = nums.Length-1; i > 0; i--)
                {
                    nums[i] = nums[i - 1];
                }

                nums[0] = preserve;
            }
            
        }
    }
}