using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3
{
    internal class Program
    {
        static int?[] FilterArray(int[] originalArray, int[] filterArray)
        {
            int?[] resultList = new int?[originalArray.Length];

            for (int i = 0; i < resultList.Length; i++)
            {
                resultList[i] = null;
            }

            foreach (int num in originalArray)
            {
                if (!filterArray.Contains(num))
                {
                    for (int i = 0; i < resultList.Length; i++)
                    {
                        if (resultList[i] == null)
                        {
                            resultList[i] = num;
                            break;
                        }
                    }
                }
            }

            return resultList;
        }

        static void Main(string[] args)
        {
            //int lenght;
            //char symbval = ' ';

            //Console.Write("Enter lenght of square: ");
            //Int32.TryParse(Console.ReadLine(), out lenght);
            //Console.Write("Enter symbval for draw: ");
            //char.TryParse(Console.ReadLine(), out symbval);

            //for (int i = 0; i < lenght; i++)
            //{
            //    for (int j = 0; j < lenght; j++)
            //    {
            //        Console.Write(symbval + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("Enter num: ");
            //string num = Console.ReadLine();
            //bool is_palindrom = true;

            //for (int i = 0; i < num.Length/2; i++)
            //{
            //    if (num[i] != num[num.Length-i-1])
            //    {
            //        is_palindrom=false;
            //        break;
            //    }
            //}
            //Console.WriteLine($"{num} - is palindrom = {is_palindrom}");

            //int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            //int[] filterArray = { 6, 88, 7 };

            //int?[] result = FilterArray(originalArray, filterArray);

            //Console.Write("Результат работы метода: ");
            //for (int i = 0; i < result.Length; i++)
            //{
            //    if (result[i] == null)
            //    {
            //        continue;
            //    }
            //    Console.Write(result[i] + " ");
            //}
        }
    }
}
