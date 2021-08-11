using System;
using System.Collections.Generic;
using System.Text;

namespace LittleBased
{
    public class Car
    {
        protected float speed;

        public Car(float speed)
        {
            this.speed = speed;
        }

        public float GetSpeed()
        {
            return speed;
        }

        public class Engine
        {
            private bool isStart = false;
            private string isItStarted;

            public void IsStartEngine(bool isStart)
            {
                this.isStart = isStart;
            }

            public string GetIsStarted()
            {
                isItStarted = isStart ? "Запущен" : "Не запущен";
                
                return isItStarted;
            }
        }
    }
}
