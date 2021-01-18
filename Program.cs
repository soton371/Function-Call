using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 30;
            int i = add(x, y);
            Console.WriteLine(i);
            Console.ReadLine();
        }

        static int add(int a, int b)
        {
            return a + b;
        }

    }
}
