using System;

namespace ExcecptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserira um número interiro:");
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException )
            {
                Console.WriteLine("Ocurreu Format erro: " );
            }
            catch(OverflowException)
            {
                Console.WriteLine("Ocurreu um overflow : ");
            }
            finally
            {
                Console.WriteLine("Obrigado por utilizar este programa");
            }            
            //Console.WriteLine($"O número inserido{i}");
        }
    }
}
