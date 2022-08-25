using Extensions;
using System;

namespace ExtensionMethod
{
    class Program
    {
        static void doWork()
        {
            Console.Write("Enter an integer: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"{x} in base {i} is {x.ConvertToBase(i)}");
            }
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
