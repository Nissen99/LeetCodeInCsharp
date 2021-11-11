using System;

namespace Rotate_Array_189
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] ints = new[] {2, 2, 32, 324, 2, 42, 42, 4121, 4124, 2};            
            solution.Rotate(ints, 11939);
            

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
        }
    }
}