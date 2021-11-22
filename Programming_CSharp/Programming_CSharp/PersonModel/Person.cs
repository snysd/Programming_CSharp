using System;


namespace Programming_CSharp.PersonModel
{
    class Person
    {
        string name;
        int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void SelfIntroduction()
        {
            Console.WriteLine($"こんにちは、私の名前は{name}です。{age}歳です。");
        }
    }
}
