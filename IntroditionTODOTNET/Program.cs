//#define STRING_OPERATIONS
//#define DATA_TYPES
//#define NUMERIC_TYPES
#define FACTORIAL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroditionTODOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if STRING_OPERATIONS
        
            //Console.WriteLine("\t\t\t\tHello .NET");
            //Console.WriteLine("Привет");
            Console.Write("Введите Ваше имя: ");
            string first_name = Console.ReadLine();

            Console.Write("Введите Вашу фамилию: ");
            string last_name = Console.ReadLine();

            Console.Write("Введите Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(first_name + " " + last_name + " " + age);//Конкатенация строк
            Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age)); // Форматирование строк
            Console.WriteLine($"{first_name} {last_name} {age}"); // Интерполяция строк  
        
#endif

#if DATA_TYPES
            Console.WriteLine(sizeof(bool));
            //Console.WriteLine(Boolean.);
            bool var1;
            Boolean var2;


#endif
#if NUMERIC_TYPES
            string[] types = { "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong", "double", "float" };

            Console.WriteLine("=================================================================================");
            Console.WriteLine("| Тип      | Размер | Минимальное значение         | Максимальное значение        |");
            Console.WriteLine("=================================================================================");

            foreach (var typeName in types)
            {
                switch (typeName)
                {
                    case "byte":
                        Console.WriteLine($"|{"byte",-10}|{sizeof(byte),-8}|{byte.MinValue,-30}|{byte.MaxValue,-30}|");
                        Console.WriteLine("=================================================================================");
                        break;
                        case "sbyte":
                        Console.WriteLine($"|{"sbyte",-10}|{sizeof(sbyte),-8}|{sbyte.MinValue,-30}|{sbyte.MaxValue,-30}|");
                        Console.WriteLine("=================================================================================");
                        break;
                        case "short":
                        Console.WriteLine($"|{"short",-10}|{sizeof(short),-8}|{short.MinValue,-30}|{short.MaxValue,-30}|");
                        Console.WriteLine("=================================================================================");
                        break; 
                        case "ushort":
                        Console.WriteLine($"|{"ushort",-10}|{sizeof(ushort),-8}|{ushort.MinValue,-30}|{ushort.MaxValue,-30}|");
                        Console.WriteLine("=================================================================================");
                        break; 
                        case "int":
                        Console.WriteLine($"|{"int",-10}|{sizeof(int),-8}|{int.MinValue,-30}|{int.MaxValue,-30}|");
                        Console.WriteLine("=================================================================================");
                        break;
                        case "uint":
                        Console.WriteLine($"|{"uint",-10}|{sizeof(uint),-8}|{uint.MinValue,-30}|{uint.MaxValue,-30}|");
                        Console.WriteLine("=================================================================================");
                        break;
                        case "long":
                        Console.WriteLine($"|{"long",-10}|{sizeof(long),-8}|{long.MinValue,-30}|{long.MaxValue,-30}|");
                        Console.WriteLine("=================================================================================");
                        break;
                        case "ulong":
                        Console.WriteLine($"|{"ulong",-10}|{sizeof(ulong),-8}|{ulong.MinValue,-30}|{ulong.MaxValue,-30}|");
                        Console.WriteLine("=================================================================================");
                        break;
                        case "double":
                        Console.WriteLine($"|{"double",-10}|{sizeof(double),-8}|{double.MinValue,-30}|{double.MaxValue,-30}|");
                        Console.WriteLine("=================================================================================");
                        break;
                        case "float":
                        Console.WriteLine($"|{"float",-10}|{sizeof(float),-8}|{float.MinValue,-30}|{float.MaxValue,-30}|");
                        Console.WriteLine("=================================================================================");
                        break;
                }
            }

#endif
#if FACTORIAL

            Console.Write("Введите число: "); 
            string sinput = Console.ReadLine();
            int.TryParse(sinput, out int input);
            ulong factorial = 1;
            for (int i = 0; i < input; i++)
            {
             factorial *= (ulong)(i + 1);
            }
            Console.WriteLine($"Факториал числа {input} равен {factorial} ");



#endif


        }

    }

 }
