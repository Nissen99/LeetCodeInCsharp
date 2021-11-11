using System;

namespace SearchInsertPosition35
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] ints = new[] {1, 3, 5, 6};
            Console.WriteLine(solution.SearchInsert(ints, 5));
        }
    }
}