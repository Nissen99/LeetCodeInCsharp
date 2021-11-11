﻿namespace SearchInsertPosition35
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {

            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = low + ((high - low) / 2);

                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
                
            }

            return low + ((high - low) / 2);
        }
    }
}