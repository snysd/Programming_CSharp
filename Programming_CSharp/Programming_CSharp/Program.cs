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
        static void Main(string[] args)
        {
            aaa<int>(22);
            aaa<double>(1.56);
            aaa<string>("qwertr");
        }

        static void aaa<T>(T i)
        {
            Console.WriteLine(i.GetType());
        }

    }
   
}
