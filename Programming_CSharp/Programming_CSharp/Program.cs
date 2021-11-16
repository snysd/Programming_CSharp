using System;

namespace Programming_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 3; i < 6; i++)
            {
                CreateTriangle(i);
            }
        }

        static void CreateTriangle(int size)
        {
            for (var i = 0; i < size; i++)
            {
                string str = "$";
                for (int j = 0; j < i; j++)
                {
                    str += "$";
                }
                Console.WriteLine(str);
            }
        }


    }
}
