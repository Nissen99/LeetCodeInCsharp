using System.Collections.Generic;

namespace Two_Sums_1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target) {
      
            Dictionary<int, int> set = new Dictionary<int, int>();
            
            for(int i = 0; i < nums.Length; i++){

                if (set.ContainsKey(nums[i]))
                {
                    return new int[] {set[nums[i]], i};
                    
                }
                set.TryAdd(target-nums[i], i);

            }

            return nums;
        } 
    }
}