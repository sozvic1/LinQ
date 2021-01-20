using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static int[] value = new int[30];
        public static void FillArray()
        {
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = new Random().Next(-100, 100);
            }
        }
        public static void PrintArray()
        {
            for (int i = 0; i < value.Length; i++)
            {
                Console.Write($"{value[i]}, " );
            }
            Console.WriteLine();

            var firstPozitiv = value.Where(x => x > 0).FirstOrDefault();
            var last = value.Where(x => x < 0).LastOrDefault();

            Console.WriteLine($" первое позитивное число {firstPozitiv}, последний негативное число {last}");
        }       

        static void Main(string[] args)
        {
            FillArray();
            PrintArray();           
           
        }
    }

}
