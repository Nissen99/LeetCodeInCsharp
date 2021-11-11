using System;

namespace Merge_Sorted_Array_88
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] ints = new[] {1, 2, 3, 0, 0, 0};
            int[] ints2 = new[] {2,5,6};
            solution.Merge(ints, 3, ints2, 3);

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
        }
    }
}