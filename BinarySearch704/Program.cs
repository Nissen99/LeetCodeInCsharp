using System;

namespace BinarySearch704
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            AnotherSolution anotherSolution = new AnotherSolution();
            int[] ints = new[] {-1, 0, 3, 5, 9, 12};
            Console.WriteLine(solution.Search(ints, 3));
            Console.WriteLine(anotherSolution.Search(ints, 3));

        }
    }
}