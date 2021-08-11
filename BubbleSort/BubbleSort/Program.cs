using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            Random rand = new Random();
            int temp;

            Console.WriteLine("Массив с рандомными элементами: ");


            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(0, 101); //Создаем рандомные элементы в массиве
                Console.Write(mas[i] + "\t"); //Выводим на экран все элементы массива
            }
            Console.WriteLine(" ");
            
            
            //Создаем ебучий пузырь
            Console.WriteLine("Отсортированный массив: ");

            int s = 1;
            for (int j = 0; j < mas.Length; j++)
            {
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    if (mas[i] * s > mas[i + 1] * s)
                    {
                        temp = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = temp;
                    }
                }
            }

            for (int i = 0; i< mas.Length; i++)
            {
                Console.Write(mas[i] + "\t");  //Выводим на экран все отсортированные элементы массива
            }
            Console.WriteLine(" ");

            Console.WriteLine("Реверсирный отсортированный массив");

            int ReverSe = -1;
            for (int j = 0; j < mas.Length; j++)
            {
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    if (mas[i] * ReverSe > mas[i + 1] * ReverSe)
                    {
                        temp = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + "\t");  //Выводим на экран все отсортированные элементы массива
            }

            Console.WriteLine(" ");
            Console.WriteLine("Таблица умножения: ");

            for (int i = 1; i < 10; i++)
            {
                Console.Write(i + "   |  ");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("\t" + i * j);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
