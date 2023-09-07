using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Задание 1. Напишите программу, которая выводит на экран 3 строки.");


            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир\n Труд\n   Май\n");


            Console.WriteLine(" Задание 2. Написать программу, которая меняет две перменные местами и выводит их на экран.\n");


            /*
            Console.WriteLine("Введите первую числовую переменную.");
            double FirstVariable = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую числовую переменную");
            double SecondVariable = double.Parse(Console.ReadLine());
            FirstVariable = SecondVariable;
            SecondVariable = FirstVariable;
            Console.WriteLine("Первая перменная = " +  FirstVariable);
            Console.WriteLine("Вторая переменная = " +  SecondVariable); */
            

            Console.WriteLine(" Задание 3. Дан радиус окружности. Найти длину окружности и площадь круга. ");


            double NumPI = 3.14;
             Console.WriteLine("Введите радиус окружности. ");
            double Radius = double.Parse(Console.ReadLine());
             Console.WriteLine("Длина окружности = " + 2* NumPI*Radius);
            Console.WriteLine("Площадь круга = " +  Radius*Radius*NumPI);
           

            Console.WriteLine("\n Задание 4. Найдите y = cos(x).");
            
            Console.WriteLine("Введите значение х в радианах.");
             double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Cos(x) = " + Math.Cos(x));

            Console.WriteLine("\n Задание 7. Составить программу вывода на экран четырех случайных чисел.");

            Console.WriteLine("Введите первое число.");
             double FirstNumb = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число.");
             double SecondNumb = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье чимсло.");
             double ThirdNumb = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите четвертое число.");
             double FourthNumb = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
             Console.WriteLine(FirstNumb);
            Console.WriteLine(SecondNumb);   
             Console.WriteLine(ThirdNumb);
            Console.WriteLine(FourthNumb);

            Console.WriteLine("Задание 9. Найти стоимость покупки. ");

            Console.WriteLine("Введите стоимость одного килограмма конфет.");
             double PriceOfCandies = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стомиость одного кг печенья.");
             double PriceOfCookies = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость одного кг яблок.");
             double PriceOfApples = double.Parse(Console.ReadLine());
            double Sum = 0;
             Console.WriteLine("Введите количество купленных конфет в кг. ");
            double CandiesWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количсетво купленного печенья в кг. ");
             double CookiesWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество купленных яблок в кг. ");
            double ApplesWeight = double.Parse(Console.ReadLine());
             Sum = (PriceOfCandies*CandiesWeight) + (PriceOfCookies*CookiesWeight) + (PriceOfApples*ApplesWeight);
            Console.WriteLine(Sum + " Руб");

            Console.WriteLine("Задание 8. Заменить последнюю цифру числа на первую. ");

           

        }
    }
}
