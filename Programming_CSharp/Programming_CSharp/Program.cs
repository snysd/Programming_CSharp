using System;

namespace Programming_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("yoshida", 12, 12345, 3);
            student.SelfIntroduction();
            student.StudentIntroduction();
        }

    }

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

    class Student : Person
    {
        int studentId;
        int studentGrade;

        public Student(string name, int age, int studentIdIn, int studentGradeIn): base(name,age)
        {
            studentId = studentIdIn;
            studentGrade = studentGradeIn;
        }

        public void StudentIntroduction()
        {
            Console.WriteLine($"私の学籍番号は{studentId}です。私の学年は{studentGrade}です。");
        }
    }
}
