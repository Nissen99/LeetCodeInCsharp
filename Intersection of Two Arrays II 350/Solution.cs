using System.Collections.Generic;

namespace Intersection_of_Two_Arrays_II_350
{
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {

            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            List<int> list = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                dictionary.TryAdd(nums1[i], i);
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (dictionary.ContainsKey(nums2[i]))
                {
                    list.Add(nums2[i]);
                }
            }

            return list.ToArray();

        }
    }
}