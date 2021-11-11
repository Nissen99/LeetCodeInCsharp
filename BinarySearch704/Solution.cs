namespace BinarySearch704
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            return binSeach(nums, target, 0, nums.Length - 1);
        }

        private int binSeach(int[] nums, int target, int left, int right)
        {

            if (left > right)
            {
                return -1;
            }

            int mid = (left + right) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                return binSeach(nums, target, mid + 1, right);
            } else 
            {
                return binSeach(nums, target, left, mid - 1);
            }
          

        }
    }
}