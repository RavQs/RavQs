using System;

namespace CraussMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Num1 = new int[2, 2];
            int[,] Num2 = new int[2, 2];
            int[,] Sum = new int[2, 2];

            Console.WriteLine("Введите элементы первого массива 3x3:");
            InputArray(Num1); //Ввод данных пользователя
            Console.WriteLine("Введите элементы второго массива 3x3: ");
            InputArray(Num2);
            Console.WriteLine("");

            Console.WriteLine("Элементы массивов равны:  "); //Вывод значений массивов
            DisplayArray(Num1); 
            DisplayArray(Num2);
            Console.WriteLine("");

            Console.WriteLine("Теперь процесс метода крамера:");
            KramerSum(Sum, Num1, Num2); //Вычисоение Массивов методом Крамера

            foreach (int i in Sum)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine("");
            Console.WriteLine("Finished");
        }
        public static int[,] InputArray(int[,] num1)
        {
            for (int j = 0; j < num1.GetLength(0); j++)
                for (int i = 0; i < num1.GetLength(1); i++)
                {
                    Console.WriteLine("x: " + j + " y: " + i);
                    num1[j, i] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine();

            return num1;  
        }

        public static int[,] DisplayArray(int[,] num1)
        {
            foreach (int i in num1)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            return num1;
        }

        public static int[,] KramerSum(int[,] Sum, int[,] num1, int[,] num2)
        {
            Sum[0, 0] = (num1[0, 0] * num2[0, 0]) + (num1[0, 1] * num2[1, 0]);
            Sum[0, 1] = (num1[0, 0] * num2[0, 1]) + (num1[0, 1] * num2[1, 1]);
            Sum[1, 0] = (num1[1, 0] * num2[0, 0]) + (num1[1, 1] * num2[1, 0]);
            Sum[1, 1] = (num1[1, 0] * num2[0, 1]) + (num1[1, 1] * num2[1, 1]);
            return Sum;
        }
    }
}