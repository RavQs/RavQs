using System;

namespace calc_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            char math;
            Console.WriteLine("Введите первое число: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Ввелите знак");
            math = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = float.Parse(Console.ReadLine());
            MathMethod(a, b, math);

        }

        public static void MathMethod(float a, float b, Char math) 
        { 
            switch (math)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, a* b);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadLine();
    }
    }
}
