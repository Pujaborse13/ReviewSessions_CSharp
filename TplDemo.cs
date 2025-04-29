using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_5
{
    /* Use TPL to perform three independent operations in parallel:
        Write numbers to a file.
        Calculate the sum of an array.
        Sort a list of strings.

     */
    internal class TplDemo
    {
        public async Task ThreeTask()
        {
            string filPath = @"D:\AcessMeditech\ReviewSession_5\ReviewSession_5\number.txt";
            int[] numbers = { 10, 20, 30, 40, 50 };
            List<string> names = new List<string> { "Puja", "Asmita", "Pratibha", "Komal", "Mansi" };


            Task writeToFileTask = WriteToFile(filPath);
            Task<int> sumTask = CalculateSumOfArray(numbers);
            Task<List<string>> sortTask = SortListAsync(names);

            await Task.WhenAll(writeToFileTask, sumTask, sortTask);



        }

        public async Task WriteToFile(string filePath)
        {
            using StreamWriter writer = new StreamWriter(filePath);
            for (int i = 1; i <= 10; i++)
            {
                await writer.WriteLineAsync(i.ToString());
            }
            Console.WriteLine("Numbers written to file.");


        }

        public async Task<int> CalculateSumOfArray(int[] numbers)

        {
            return await Task.Run(() =>
            {
                int sum = numbers.Sum();
                Console.WriteLine($"Sum calculated: {sum}");
                return sum;
            });

        }


        static async Task<List<string>> SortListAsync(List<string> names)
        {
            return await Task.Run(() =>
            {
                List<string> sortedNames = names.OrderBy(name => name).ToList();
                Console.WriteLine("Names sorted.");
                return sortedNames;
            });
        }


    }
}
