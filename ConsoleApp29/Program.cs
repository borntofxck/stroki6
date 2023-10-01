using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            int n = input.Length;
            string result = "";
            for (int i = 0; i < n / 2; i++)
            {
                if (input[i] == ':')
                {
                    result += '*';
                }
                else
                {
                    result += input[i];
                }
            }
            for (int i = n / 2; i < n; i++)
            {
                if (input[i] == '!')
                {
                    result += '.';
                }
                else
                {
                    result += input[i];
                }
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
