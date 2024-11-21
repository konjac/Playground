using System;
using System.IO;

namespace PlayGround
{
    class Program
    {
        static void Run(int depth)
        {
            if(depth == 0)
            {
                return;
            }

            if(depth % 1000 == 0)
            {
                Console.WriteLine(depth);
            }
            File.WriteAllText($"output\\{depth}.txt", $"hello {depth}");
            Run(depth - 1);
        }

        static void Main(string[] args)
        {
            Run(10*1000);
            Console.WriteLine("Hello World!");
        }
    }
}
