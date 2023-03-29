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
            Console.Write("Введите количество элементов в массиве: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(1, 81);
            }
            Console.WriteLine("Исходный массив: ");
            PrintArray(arr);
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }

                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine("Минимальный элемент массива: " + arr[minIndex]);
            Console.WriteLine("Максимальный элемент массива: " + arr[maxIndex]);
            int temp = arr[minIndex];
            arr[minIndex] = arr[maxIndex];
            arr[maxIndex] = temp;
            Console.WriteLine("Массив после обмена: ");
            PrintArray(arr);

            Console.ReadLine();
        }
        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
