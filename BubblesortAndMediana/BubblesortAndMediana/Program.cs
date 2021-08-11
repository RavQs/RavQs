using System;

namespace BubblesortAndMediana
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 15,240, 36, 1242, 1, 0, 76, 444};
            PrintArray(array);
            BubbleSort(array);
            FindMediana(array);

        }
        public static void PrintArray(int[] array)
        {
            foreach (int el in array)
            {
                Console.Write(el + "\t");
            }
            Console.WriteLine("");
        }

        public static void BubbleSort(int[] array)
        {
            int temp;
            int direction = 1;

            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] * direction > array[i + 1] * direction)
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            PrintArray(array);
        }

        public static void FindMediana(int[] array)
        {
            int avrgNum = 0;
            int mediana = 0;
            for (int i = 0; i< array.Length; i++)
            {
                avrgNum += array[i];
                if(i == array.Length / 2)
                {
                    mediana = array[i];
                }
            }
            Console.WriteLine(avrgNum);
            Console.WriteLine("Число четное и выполнено среднее арифметическое");
            Console.WriteLine(avrgNum / array.Length);
            Console.WriteLine($"Медиана равна = {mediana}");

        }
    }
}
