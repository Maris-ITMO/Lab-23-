using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_23_СамРабота_Асинхронное_программирование
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Максимальное значение в массиве равно: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = await FactorialAsync(number);
            Console.WriteLine($"Факториал из {number} is {result}.");
            Console.ReadKey();
        }
        static async Task<int> FactorialAsync(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
                await Task.Delay(100);
            }
            return result;
        }
    }
}
