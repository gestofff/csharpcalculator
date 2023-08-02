using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                startingPoint:

                Console.Clear();

                double a, b;

                string operation;


                try
                {

                    Console.WriteLine("Введите первое число:");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Выберите операцию: +, -, *, /");
                    operation = Console.ReadLine();

                } 
                catch (FormatException)
                {
                    Console.WriteLine("Нельзя вводить символы туда, где должны быть числа!");
                    Console.ReadKey();
                    goto startingPoint;
                }



                switch (operation)
                {
                    case "+":
                        {
                            Console.WriteLine(a + b);
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine(a - b);
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine(a * b);
                            break;
                        }
                    case "/":
                        {
                            if (b != 0)
                            {
                                Console.WriteLine(a / b);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Деление на 0 невозможно.");
                                Console.WriteLine("Нажмите любую кнопку");

                                Console.ReadKey();

                                goto startingPoint;
                            }
                        }
                    default:
                        {
                            Console.WriteLine("Неизвестная операция.");
                            break;
                        }
                }

                Console.ReadKey();
            }

        }
    }
}
