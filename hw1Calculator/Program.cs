using System;

namespace hw1Calculator
{
    class hw1Calculator
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Некорректный формат ввода.");
                return;
            }

            double a, b;
            if (!double.TryParse(args[0], out a) || !double.TryParse(args[2], out b))
            {
                Console.WriteLine("Некорректные операнды.");
                return;
            }

            string oper = args[1];
            double result = 0;
            string operStr = "";

            switch (oper)
            {
                case "+":
                    result = a + b;
                    operStr = "сложения";
                    break;
                case "-":
                    result = a - b;
                    operStr = "вычитания";
                    break;
                case "*":
                    result = a * b;
                    operStr = "умножения";
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Деление на ноль невозможно.");
                        return;
                    }
                    result = a / b;
                    operStr = "деления";
                    break;
                default:
                    Console.WriteLine("Некорректный оператор.");
                    return;
            }

            Console.WriteLine($"{a} {oper} {b} = {result}");
            Console.WriteLine($"В результате операции {operStr} чисел {a} и {b} получился ответ {result}.");
        }
    }
}