using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Task_async_await
{
    public class Program
    {
        public static async Task Main()
        {
            const ushort ARRAYSIZE = 10;
            int[] myArr = new int[ARRAYSIZE];

            var createArray = CreateArray(myArr);
            var multiplyArray = MultiplyArray(myArr);
            var sortArray = SortArray(myArr);
            var averageArray = AverageArray(myArr);

            await createArray;
            await multiplyArray;
            await sortArray;
            await averageArray;

            Console.ReadLine();
        }
        async static Task CreateArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10);
            }
            Print(array, "Create array");
        }
        async static Task MultiplyArray(int[] array)
        {
            Random random = new Random();
            int value = random.Next(10);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= value;
            }
            Print(array, "Multiply");
        }
        async static Task SortArray(int[] array)
        {
            Array.Sort(array);
            Print(array, "Sort array");
        }
        async static Task AverageArray(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Average of array is : {sum /= (double)array.Length}");
        }
        static void Print(int[] array, string nameMethod)
        {
            Console.WriteLine($"This is {nameMethod} method:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
        }
    }
}
