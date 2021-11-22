using System;
using Programming_CSharp.PersonModel;
using Programming_CSharp.Stack;

namespace Programming_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee John = new Employee("John", 35, 11926, "開発部");
            Console.WriteLine(InfoStack.name);
            Employee Ken = new Employee("Ken", 28, 38771, "営業部");
            Console.WriteLine(InfoStack.name);
            Employee Lisa = new Employee("Lisa", 44, 2991, "情報セキュリティ");
            Console.WriteLine(InfoStack.name);
        }
    }
}
