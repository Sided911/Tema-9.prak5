using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double[] arr = new double[12];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("Массив в порядке убывания: ");
            foreach (double item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            double min = arr[arr.Length - 1];
            double max = arr[0];
            double sum = min + max;
            Console.WriteLine($"Минимальный элемент массива: {min}");
            Console.WriteLine($"Максимальный элемент массива: {max}");
            Console.WriteLine($"Сумма максимального и минимального элементов: {sum}");
            Console.ReadLine();
        }
    }
}
