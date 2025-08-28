using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите простое выражение: ");
            string input = Console.ReadLine();
            string cleaned = input.Replace(" ", "");
            char[] operators = { '+', '-', '*', '/' };
            int operatorIndex = cleaned.IndexOfAny(operators , 1);
            string first = cleaned.Substring(0, operatorIndex);
            string operation = cleaned[operatorIndex].ToString();
            string second = cleaned.Substring(operatorIndex + 1);
            int.TryParse(first, out int intfirst);
            int.TryParse(second, out int intsecond);
            long result = 0;
            switch(operation)
            {
                case "+":
                    result = intfirst + intsecond;
                break;
                case "-":
                    result = intfirst - intsecond;
                break;
                case "*":
                    result = intfirst * intsecond;
                break;
                case "/":
                    result = intfirst / intsecond;
                break;
            }
            Console.Write($"Ответ: {result}");
        }
    }
}