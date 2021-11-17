using System;

namespace Programming_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Start();

  
        }

    }

    class Car
    {
        int tire = 4;
        int handle = 1;
        public void Start()
        {
            Console.WriteLine("Start");
        }
        void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
