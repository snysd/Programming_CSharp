using System;

namespace Programming_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle Bicycle = new Vehicle("自転車", 2);
            Bicycle.ShowDetail();

            Vehicle Car = new Vehicle("自動車", 4);
            Car.ShowDetail();
        }

    }

    class Vehicle
    {
        public Vehicle(string name, int tire)
        {
            this.name = name;
            this.tire = tire;
            Console.WriteLine("constractor");
        }

        private int handle = 1;
        public int tire;
        public string name;
        public void ShowDetail()
        {
            Console.WriteLine($"名前：{name}");
            Console.WriteLine($"タイヤの数：{tire}");
            Console.WriteLine($"ハンドルの数：{handle}");

        }

        public void Start()
        {
            Console.WriteLine("発車します");
        }

        public void Stop()
        {
            Console.WriteLine("停車します");
        }
    }
    /* 実行結果
    名前：自動車
    タイヤの数：4
    ハンドルの数：1
    名前：自転車
    タイヤの数：2
    ハンドルの数：1
    */
}
