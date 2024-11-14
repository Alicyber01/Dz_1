using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hm_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
            Console.WriteLine("Exercise 1");
            double e=Math.E;
            Console.WriteLine($"{e;F1}");


            //Вывести на экран числа 50 и 10 одно под другим
            Console.WriteLine("Exercise 2");
            Console.WriteLine(50);
            Console.WriteLine(10);



            //Составить программу вывода на экран «столбиком» четырех любых чисел
            Console.WriteLine("Exercise 3");
            Console.WriteLine(7);
            Console.WriteLine(77);
            Console.WriteLine(777);
            Console.WriteLine(7777);


            //Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
            Console.WriteLine("Exercise 4");
            Console.Write("Введите число: ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("Число, которое больше введенного на 10: " +(number+10));
    


            //Дана сторона квадрата. Найти его периметр.
            Console.WriteLine("Exercise 5");
            Console.WriteLine("Дана сторона квадрата. Найти его периметр");
            int squareSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(squareSide * 4);


            //Дан радиус окружности. Найти длину окружности и площадь круга.
            Console.WriteLine("Exercise 6");
            Console.WriteLine("Дан радиус окружности. Найти длину окружности и площадь круга.");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Длина окружности: {radius * 2 * Math.PI}");
            Console.WriteLine($"Площадь круга: {radius * radius * Math.PI}");


            //Найти значение y=cos(x)
            Console.WriteLine("Exercise 7");
            Console.WriteLine("Найти значение y=cos(x)");
            int x_7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"y = {Math.Cos(x_7)}");



            //Даны основания и высота равнобедренной трапеции. Найти ее периметр.
            Console.WriteLine("Exercise 8");
            Console.WriteLine("Найти периметр трапеции");

            Console.WriteLine("Меньшее основание: ");
            int smallerOsn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Большее основание: ");
            int biggerOsn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Высота: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Периметр трапеции: {biggerOsn + smallerOsn + 2 * Math.Sqrt(Math.Pow(height, 2) + Math.Pow((biggerOsn - smallerOsn) / 2, 2))}");



            //Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,если купили x кг конфет, у кг печенья и z кг яблок.
            Console.WriteLine("Exercise 9");
            Console.WriteLine("Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,\r\nесли купили x кг конфет, у кг печенья и z кг яблок.");

            Console.WriteLine("цена конфеты: ");
            int candyCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол-во конфет: ");
            int candysCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Цена печенья: ");
            int cookyCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол-во печенья: ");
            int cookysCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Цена яблок: ");
            int applesCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол-во яблок: ");
            int applesCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Стоимость товаров {candyCost * candysCount + cookyCost * cookysCount + applesCost * applesCount}");


            //Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
            //(кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:
            //Мир Труд Май
            //Затем так:
            //Мир
            //        Труд
            //                Май

            Console.WriteLine("Exercise 10");

            Console.Write("Мир");
            Console.Write("Труд");
            Console.Write("Май");
            Console.WriteLine($"Мир\n{"Труд",10}\n{"Май",16}");




            //Программа просит пользователя ввести 2 числовые переменные. А после она меняет их местами и выводит результат на экран. Но, так как пользователь может ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести, например, букву или строку, а так же учесть, что число может быть дробным, и для выделения её дробной части одни используют точку, другие – запятую.

            Console.WriteLine("Exercise 11");

            string firstNumber_11 = Console.ReadLine();
            string secondNumber_11 = Console.ReadLine();

            if (firstNumber_11.Contains("."))
            {
                firstNumber_11 = firstNumber_11.Replace(".", ",");
            }
            else if (secondNumber_11.Contains("."))
            {
                secondNumber_11 = secondNumber_11.Replace(".", ",");
            }

            if (double.TryParse(firstNumber_11, out double a1) & double.TryParse(secondNumber_11, out double a2))
            {

                Console.WriteLine("{1} {0}", a1, a2);
            }
            else
            {
                Console.WriteLine("Одно из введёных данных не является числом");
            }



            //Программа для подсчета периметра и площади фигур (треугольник, четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа будет считать – площадь или периметр.Задаётся все необходимые значения, а на основе полученных результатов, программа должна подсчитать, какими могли бы быть периметры или площади остальных фигур.
            Console.WriteLine("Exercise 12");

            Console.WriteLine("Выберите фигуру: треугольник, четырёхугольник, круг:");
            string obj = Console.ReadLine();

            switch (obj)
            {

                case "треугольник":
                    Console.WriteLine("Укажите стороны треугольника");
                    int a1_12 = Convert.ToInt32(Console.ReadLine());
                    int a2_12 = Convert.ToInt32(Console.ReadLine());
                    int a3_12 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("площадь или периметр?");
                    string triangeOperation = Console.ReadLine();
                    if (triangeOperation == "периметр")
                    {
                        Console.WriteLine(a1_12 + a2_12 + a3_12);
                    }
                    else
                    {
                        float halfPerimitr = (float)(a1_12 + a2_12 + a3_12) / 2;
                        Console.WriteLine(Math.Sqrt(halfPerimitr * (halfPerimitr - a1_12) * (halfPerimitr - a2_12) * (halfPerimitr - a3_12)));
                    }
                    break;

                case "четырёхугольник":
                    Console.WriteLine("Укажите стороны четырёхугольника");
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    int b2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("площадь или периметр?");
                    string QuadrangleOperation = Console.ReadLine();
                    if (QuadrangleOperation == "периметр")
                    {
                        Console.WriteLine((b1 + b2) * 2);
                    }
                    else
                    {
                        Console.WriteLine(b1 * b2);
                    }
                    break;
                case "круг":
                    Console.WriteLine("Укажите радиус круга");
                    int r = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("площадь или периметр?");
                    string operation = Console.ReadLine();
                    if (operation == "периметр")
                    {
                        Console.WriteLine(2 * Math.PI * r);
                    }
                    else
                    {
                        Console.WriteLine(Math.PI * r * r);
                    }
                    break;
            }



            //Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому числу должно предшествовать сообщение «Вы ввели число».
            Console.WriteLine("Exercise 13");

            Console.WriteLine($"Вы ввели число: {Console.ReadLine()}");




            // Составить программу вывода на экран следующей информации: 2кг 13 17
            Console.WriteLine("Exercise 14");

            Console.WriteLine("2кг");
            Console.WriteLine("13 17");



            //Составить программу вывода на экран «столбиком» четырех случайных чисел.
            Console.WriteLine("Exercise 15");

            Random random = new Random();

            Console.WriteLine(random.Next(1, 100));
            Console.WriteLine(random.Next(1, 100));
            Console.WriteLine(random.Next(1, 100));
            Console.WriteLine(random.Next(1, 100));




            //Найти корни квадратного уравнения(коэффициента задаются пользователем с клавиатуры)

            Console.WriteLine("Exercise 16");

            Console.WriteLine("Enter the coefficients:");
            float a = Convert.ToInt32(Console.ReadLine());
            float b = Convert.ToInt32(Console.ReadLine());
            float c = Convert.ToInt32(Console.ReadLine());
            if (a != 0)
            {
                double Discriminant = b * b - 4 * a * c;
                double x1 = (-b + Math.Sqrt(Discriminant)) / 2 * a;
                double x2 = (-b - Math.Sqrt(Discriminant)) / 2 * a;
                Console.WriteLine($"First result {x1}");
                Console.WriteLine($"Second result {x2}");
            }
            else if (b != 0)
            {
                float x = c / b;
                Console.WriteLine($"Result {x}");
            }
            else
            {
                Console.WriteLine($"Result {c}");
            }


            //Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
            Console.WriteLine("Exercise 17");

            int firstNumber_17 = Convert.ToInt32(Console.ReadLine());
            int secondNumber_17 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Среднее арифмитическое: {(firstNumber_17 + secondNumber_17) / 2}");
            Console.WriteLine($"Среднее геометрическое: {Math.Sqrt(firstNumber_17 * secondNumber_17)}");



            //Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.WriteLine("Exercise 18");

            Console.Write("X1: ");
            int x1_18 = Convert.ToInt32(Console.ReadLine());

            Console.Write("X2: ");
            int x2_18 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Y1: ");
            int y1_18 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Y2: ");
            int y2_18 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Растояние между двумя точками: {Math.Sqrt(Math.Pow(x2_18 - x1_18, 2) + Math.Pow(y2_18 - y1_18, 2))}");




            //Составить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам:

            Console.WriteLine("Exercise 19");

            int a1_19 = 4;
            int b1_19 = 5;
            int c1_19 = 7;

            Console.WriteLine("Пункт а до преобразований: {0} {1} {2}", a1_19, b1_19, c1_19);

            int a2_19 = 4;
            int b2_19 = 5;
            int c2_19 = 7;

            Console.WriteLine("Пункт b до преобразований: {0} {1} {2}", a2_19, b2_19, c2_19);



            (a1_19, b1_19, c1_19) = (b1_19, c1_19, a1_19);
            (a2_19, b2_19, c2_19) = (c2_19, a2_19, b2_19);

            Console.WriteLine("Пункт а после преобразований: {0} {1} {2}", a1_19, b1_19, c1_19);
            Console.WriteLine("Пункт а после преобразований: {0} {1} {2}", a2_19, b2_19, c2_19);




            //С начала суток прошло n секунд. Определить:
            //а) сколько полных часов прошло с начала суток;
            //б) сколько полных минут прошло с начала очередного часа;
            //в) сколько полных секунд прошло с начала очередной минуты.

            Console.WriteLine("Exercise 20");

            int seconds = Convert.ToInt32(Console.ReadLine());
            int minutes = seconds / 60;
            int hours = minutes / 60;

            Console.WriteLine($"С начала суток прошло {hours} часов {minutes} минут {seconds % 60} секунд");
        }
    }
}
