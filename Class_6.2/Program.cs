using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startStr = Console.ReadLine(); // Вводим строку
            string reverseStr = ""; // здесь будет перевернутая строка.
            for (int i = startStr.Length - 1; i >= 0; i--)   
            {
                reverseStr += startStr[i]; // переворачиваем строку
            }
            if (startStr == reverseStr)
            {
                Console.WriteLine("Введенная строка является палиндромом.");
            }    
            else
            { 
                Console.WriteLine("Введенная строка не является палиндромом."); 
            }
            Console.ReadKey();
        }
    }
}
