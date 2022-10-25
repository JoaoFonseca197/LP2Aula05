using System;

namespace ExcecptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserira um número interiro:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O número inserido{i}");
        }
    }
}
