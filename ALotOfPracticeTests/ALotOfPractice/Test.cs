using System;

namespace ALotOfPractice
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер метода для выполнения: 1-12");
            byte num = Convert.ToByte(Console.ReadLine());
            WhichMethodToUse(num);

        }

        public static void WhichMethodToUse(byte num)
        {
            switch (num)
            {
                case 1:
                    ChangeNums();
                    break;
                case 2:
                    DividingNum();
                    break;
                case 3:
                    JustSomeNumsAndChars();
                    break;
                case 4:
                    UrNameAndAge();
                    break;
                case 5:
                    HowManyYearsInDays();
                    break;
                case 6:
                    SummNumberFormula();
                    break;
                case 7:
                    UrNameAndAgeHaveCar();
                    break;
                case 8:
                    WhichDomain();
                    break;
                case 9:
                    UrAge();
                    break;
                case 10:
                    CircleTesting();
                    break;
                case 11:
                    SwitchTesting();
                    break;
                case 12:
                    InputArray();
                    break;
            }
        }


        public static void ChangeNums()
        {
            Console.WriteLine("Введите первое значение");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int temp;
            Console.WriteLine($" Значение1 : {Num1}, Значение2 : {Num2}");
            temp = Num1;
            Num1 = Num2;
            Num2 = temp;
            Console.WriteLine($" Значение1 : {Num1}, Значение2 : {Num2}");

        } //   1


        public static void DividingNum()
        {
            int num = 7894;
            int a, b, c, d;
            Console.WriteLine($"Число равно {num}");
            a = num / 1000;
            b = num / 100 % 10;
            c = num / 10 % 10;
            d = num % 10;

            Console.WriteLine($"{a}, {b}, {c}, {d}");

        }   //   2


        public static void JustSomeNumsAndChars()
        {
            byte num1 = 5;
            char ch = 'F';
            string name = "Привет";
            float num2 = 90.2f;
            const int cnst = 67;

            Console.WriteLine(name);
        }  //  3

        public static void UrNameAndAge()
        {
            Console.Write("Введите имя: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Введите возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"Здарова {name}, Тебе уже {age} лет!");

        }   // 4

        public static void HowManyYearsInDays()
        {
            Console.WriteLine("Введите кол-во дней: 0000");
            int days = Convert.ToInt32(Console.ReadLine());
            int years, weeks;

            years = days / 365;
            weeks = (days % 365) / 7;
            days = days - ((years * 365) + (weeks * 7));


            Console.WriteLine($"Лет: {years}, недель: {weeks}, дней: {days}");

        }   //   5

        public static void SummNumberFormula()
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2;
            n2 = n1 * 2;

            Console.Write($"{n1}{n2}");
        }   //   6

        public static void UrNameAndAgeHaveCar()
        {
            Console.Write("Введите имя: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Введите возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Есть ли у вас машина? : Да / Нет");
            String answer = Convert.ToString(Console.ReadLine());
            if (answer is "Да")
            {
                answer = "У вас есть машина";
            }
            else if (answer is "Нет")
            {
                answer = " У вас нет машины";
            }


            Console.WriteLine("");
            Console.WriteLine($"Здарова {name}, Тебе уже {age} лет! {answer}");
        }   //  7
        
        public static void WhichDomain()
        {
            // Получаем веб сайт от пользователя
            Console.Write("Enter website: ");
            string website = Console.ReadLine();

            // Разделяем слово по символу точка
            string[] split = website.Split('.');
            // Получиться массив состоящий из двух элементов
            // Выводим в консоль последний элемент массива
            Console.Write("Domain name: " + split[split.Length - 1]);
        }

        public static void UrAge()
        {
            int age = Convert.ToInt32(Console.ReadLine());

            if(age < 18)
            {
                Console.WriteLine("Your age is less than 18");
            }
            else if(age == 18)
            {
                Console.WriteLine("Your age is 18");

            }
            else
            {
                Console.WriteLine("Your age is more than 18");
            }
            
        }

        public static void CircleTesting()
        {
            for (int a = 0; a< 55; a++)
            {

                if ((a < 50 && a != 37 && a >= 32) || (a == 0 || a == 15))
                {
                    Console.WriteLine(a + "  It's Working!");
                }
                else
                {
                    Console.WriteLine(a + "  Error");
                }
            }
        }

        public static void SwitchTesting()
        {
            for (int i = 0; i< 16; i++)
            {
                switch (i)
                {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 15:
                    Console.WriteLine("number is 15");
                    break;
                default:
                    Console.WriteLine("Something Else");
                    break;
                }
            }
        }

        public static void InputArray()
        {
            Console.WriteLine("Введите колличество элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {a[i]} элемент массива");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine("Элементы массива равны: ");
            
            for (int i = 0; i< n; i++)
            {
                Console.Write(a[i] +"\t");
            }
        }

    }


    
}
