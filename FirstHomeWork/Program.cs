using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shulyak Denis");
            Console.WriteLine("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine("Сумма чисел: " + sum);
            Console.ReadLine();
        }
    }
}
