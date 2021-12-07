using System;
using TestLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.IO;

namespace Programming_CSharp
{
     class Program
    {
        class Test<T1, T2> 
        {
            T1 x;
            T2 y;

            public Test(T1 x, T2 y)
            {
                this.x = x;
                this.y = y;
            }

            public void Method1()
            {
                Console.WriteLine(x.GetType());
            }
            public void Method2()
            {
                Console.WriteLine(y.GetType());
            }

        }

        static void Main(string[] args)
        {
            Test<int,string> t = new Test<int,string>(100, "qawsedrf");
            t.Method1();
            t.Method2();
        }
    }
   
}
