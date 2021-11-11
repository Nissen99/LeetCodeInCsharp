using System;

namespace FirstBadVersion278
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.BadVersion = 1702766719;
            Console.WriteLine(solution.FirstBadVersion(2126753390));
        }
    }
}