using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int a = 10;
                long b = 3147483648;
           // a = (int) b;
             a = ((int)b);

            Console.WriteLine(a.ToString());
            Console.ReadKey();

        }
    }
}
