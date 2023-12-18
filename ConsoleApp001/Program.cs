using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp001
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Вычислить значение функции для целых аргументов двумя способами (1-й способ: полный условный оператор; 2-й способ: тернарная операция):
            //Console.WriteLine("Введите целое значение");
            //int x = int.Parse(Console.ReadLine());
            //double y = 0;
            //if (x >= 0)
            //{
            //    /*y = Math.Sin(x) * Math.Sin(x);*/
            //    y = Math.Pow(Math.Sin(x), 2);
            //}
            //else
            //{
            //    /*y = 1 - 2 * Math.Sin(x * x);*/
            //    y = 1 - 2 * Math.Sin(Math.Pow(x, 2));
            //}
            //Console.WriteLine($"y={y:f2}");

            //2. Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции
            //Random rnd = new Random();
            //int number = rnd.Next(10, 99);
            //Console.WriteLine($"number={ number}");
            //string stroka = (number % 2 == 0) ? "четное число" : "Нечетное число ";
            //Console.WriteLine($"{stroka}");
            //Console.Readkey();

            //3.Даны три целых положительных числа. Если все они четные, каждое число увеличить на 1; если хотя бы одно из них четное, уменьшить на 1; если четных чисел нет, каждое число увеличить в 2 раза.
            //Console.WriteLine("Введите 1 число");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите 2 число");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите 3 число");
            //int c = int.Parse(Console.ReadLine());
            //if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
            //{
            //    a += 1;
            //    b += 1;
            //    c += 1;
            //}
            //else if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            //{
            //    a -= 1;
            //    b -= 1;
            //    c -= 1;
            //}
            //else
            //{
            //    a *= 2;
            //    b *= 2;
            //    c *= 2;

            //}
            //Console.WriteLine($"Результат: {a}, {b}, {c}");
            //Console.ReadKey();

            //4.По введенному номеру месяца выводится название поры года (зима, весна, лето, осень) и сообщение: сессия, каникулы, 1 семестр, 2 семестр
            Console.WriteLine("Введите номер месяца (от 1 до 12):");
            int monthNumber;
            while (!int.TryParse(Console.ReadLine(), out monthNumber) || monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("Некорректный ввод. Введите число от 1 до 12:");
            }
            string season;
            switch (monthNumber)
            {
                case 12:
                case 1:
                case 2:
                    season = "зима";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "весна";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "лето";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "осень";
                    break;
                default:
                    season = "неизвестная пора года";
                    break;
            }
            Console.WriteLine($"Месяц номер {monthNumber} соответствует поре года: {season}");
            switch (monthNumber)
            {
                case 1:
                case 7:
                case 8:
                    Console.WriteLine("Сейчас идут каникулы.");
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Сейчас идет 2 семестр.");
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Сейчас идет 1 семестр.");
                    break;
                default:
                    Console.WriteLine("Некорректный месяц для определения сессии/каникул.");
                    break;
            }
            Console.ReadKey();
            }
    }
}
