using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Color
    {
        Red,
        Green,
        Blue,
        Yellow,
        Cyan,
        Magenta
    }

    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    internal class Program
    {
        public static void PrintDay(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Понедельник");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Вторник");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Среда");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Четверг");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Пятница");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Суббота");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Воскресенье");
                    break;
            }
        }

        public static string GetHexCode(Color color)
        {
            switch (color)
            {
                case Color.Red:
                    return "#FF0000";
                case Color.Green:
                    return "#00FF00";
                case Color.Blue:
                    return "#0000FF";
                case Color.Yellow:
                    return "#FFFF00";
                case Color.Cyan:
                    return "#00FFFF";
                case Color.Magenta:
                    return "#FF00FF";
                default:
                    return "#FFFFFF";
            }
        }

        public static double Calculate(double a, double b, Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return a + b;
                case Operation.Subtract:
                    return a - b;
                case Operation.Multiply:
                    return a * b;
                case Operation.Divide:
                    if (b == 0)
                        throw new DivideByZeroException("Деление на ноль невозможно.");
                    return a / b;
                default:
                    throw new InvalidOperationException("Неизвестная операция.");
            }
        }

        static void Main(string[] args)
        {
            PrintDay(DayOfWeek.Monday);

            Console.WriteLine(GetHexCode(Color.Red));

            try
            {
                Console.WriteLine(Calculate(7, 5, Operation.Add));
                Console.WriteLine(Calculate(99, 0, Operation.Divide));
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }

            Console.ReadKey();
            
        }
    }
}
