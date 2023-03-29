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
            double[] arr = new double[14];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < 14; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(arr, 0, 7);
            Array.Sort(arr, 7, 7);
            Array.Reverse(arr, 7, 7);
            Console.WriteLine("Массив с сортировкой:");
            foreach (double item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
