using System;

namespace BinarySearch704
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] ints = new[] {-1, 0, 3, 5, 9, 12};
            Console.WriteLine(solution.Search(ints, 2));
        }
    }
}