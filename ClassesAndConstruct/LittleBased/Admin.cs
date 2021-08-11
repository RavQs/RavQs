using System;
using System.Collections.Generic;
using System.Text;

namespace LittleBased
{
    public  class Admin : Base
    {
        private string role;

        public Admin(string name, byte age, string email, string password, string role)
            : base(name,age,email,password)
        {
            this.role = role;
        }
        
        public void GetRole()
        {
            Console.WriteLine($"Роль = {role}");
        }

        public override void PrintAll()
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}, Почта: {email}, Пароль: {password}, Роль: {role}");
        }

    }
}
