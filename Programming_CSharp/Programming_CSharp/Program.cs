using System;
using System.IO;     //ファイル操作
using System.Text;　 //高度な文字処理
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Programming_CSharp
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"C:\Programming\SRC\Programming_CSharp\Programming_CSharp\test.json";
            string jsonString = File.ReadAllText(fileName);
            Person person = JsonSerializer.Deserialize<Person>(jsonString);

            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Country: {person.Country}");
        }
    }
}
