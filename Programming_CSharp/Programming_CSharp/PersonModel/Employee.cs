using System;
using Programming_CSharp.Stack;

namespace Programming_CSharp.PersonModel
{
    class Employee : Person
    {
        int id;
        string department;

        public Employee(string name, int age, int id, string department) : base(name, age)
        {
            this.id = id;
            this.department = department;

            InfoStack.name = name;
            InfoStack.id = id;
            InfoStack.age = age;
        }

        public void CompanyIntroduction()
        {
            Console.WriteLine($"社員番号：{id}、部署：{department}");
        }
    }
}
