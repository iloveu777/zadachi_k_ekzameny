using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Random rnd = new Random();
            double[] mas = new double[6];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = -10 + 20 * rnd.NextDouble();
            }
            foreach (double el in mas)
            {
                Console.WriteLine($"{el} \t");

            }
            Console.WriteLine($"последний элемент массива - {mas[mas.Length - 1]}");
            Console.ReadKey(); */

            // 38 задача
            /*int[] mas = { 3, 4, -9, 8, 1, -6, 2, -5, -1, 7, 5, 9 };
            foreach (int el in mas)
            {
                Console.WriteLine($"{el} \t");

            }*/
            //39 задача
            /* int[] mas = { -5, 2, 3, 6, 7, 9, -4, 8, 1, 2, 7, -3 };
             foreach (int el in mas)
             {
                 Console.WriteLine($"{el} \t");

             } */

            //40 задача

            /* int[] mas = { -37, 0, 50, 46, 34, 46, 4, -13 };
             int k = 0;
             foreach (int el in mas)
             {
                 if (el < 0)
                 {
                     Console.WriteLine($"{el} ");
                     k++;
                 }

             }
             Console.WriteLine($"Отрицательных чисел - {k}");*/


            //41 задача
            Random rnd = new Random();
            int[] mas = new int[6];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-10, 10);
            }
            foreach (double el in mas)
            {
                Console.WriteLine($"{el} \t");

            }
            Console.ReadKey();
        }
    }
}
