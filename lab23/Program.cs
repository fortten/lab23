using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23
{
    //Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.
    class Program
    {
        static int n;

        static void Main(string[] args)
        {
            //Console.WriteLine("Начало работы метода Main");            
            try
            {
                Console.Write("Введите целое число, факториал которого хотите получить: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n >= 0)
                {
                    FactorialAsync();
                }
                else
                {
                    Console.WriteLine("Число не должно быть отрицательным");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.WriteLine("Окончание работы метода Main");            
            Console.ReadKey();
        }
        static void Factorial()
        {
            ulong result = 1;
            if (n >= 2)
            {
                for (int i = 1; i <= (n - 1); i++)
                {
                    result *= (ulong)(i + 1);
                }
            }
            Console.WriteLine($"{n}! = {result}");
        }
        static async void FactorialAsync()
        {
            //Console.WriteLine("Начало работы метода FactorialAsync");            
            await Task.Run(() => Factorial());
            //Console.WriteLine("Окончание работы метода FactorialAsync");
        }
    }
}
