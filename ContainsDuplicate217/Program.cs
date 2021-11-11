using System;

namespace ContainsDuplicate217
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] ints = new[] {1, 2, 3, 4, 4};
            Console.WriteLine(solution.ContainsDuplicate(ints));
        }
    }
}