using System;

namespace LittleBased
{
    public class Base
    {
        public byte age;
        public string email;
        public string name;
        public string password;


        public Base(string _name, byte _age, string _email, string _password)
        {
            name = _name;
            age = _age;
            email = _email;
            password = _password;
            
        }

      

        public virtual void PrintAll()
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}, Почта: {email}, Пароль: {password}");

        }

    }
}
