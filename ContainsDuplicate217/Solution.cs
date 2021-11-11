using System.Collections.Generic;

namespace ContainsDuplicate217
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, bool> mapOverAllInts = new Dictionary<int, bool>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (mapOverAllInts.ContainsKey(nums[i]))
                {
                    return true;
                }
                mapOverAllInts.Add(nums[i], true);
            }

            return false;
        }
    }
}