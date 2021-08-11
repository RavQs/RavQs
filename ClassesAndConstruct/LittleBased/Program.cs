using System;

namespace LittleBased
{
    class Program
    {
        static void Main(string[] args)
        {
            Base director = new Base("Valera", 54, "ILoveMyLittlePony1956", "12345");
            Base programmer = new Base("Kolyan", 12, "AmongUsImpostar", "CreeperBoom2005");
            Base admin = new Admin("Vasek", 21, "VasyanPro", "TrueNagibator", "Admin");

            director.PrintAll();
            programmer.PrintAll();
            admin.PrintAll();

            Car car = new Car(120.50f);
            Console.WriteLine(car.GetSpeed());

            Car.Engine engine = new Car.Engine();
            engine.IsStartEngine(false);

            Console.WriteLine($"Запущен ли двигатель? {engine.GetIsStarted()}");


        }
    }
}
