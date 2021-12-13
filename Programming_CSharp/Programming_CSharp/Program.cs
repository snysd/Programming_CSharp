using System;
using System.Collections.Generic;

namespace Programming_CSharp
{
    delegate void AfterInputNameActions(Student student);
    public class Student
    {
        public string id;
        public string name;
        public string country;

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            AfterInputNameActions afterInputNameActions = new AfterInputNameActions((Student student) => { Console.WriteLine("こんにちは{0}さん", student.name); });
            afterInputNameActions += (Student student) => { Console.WriteLine("出席番号は{0}番です", student.id); };
            afterInputNameActions += (Student student) => {Console.WriteLine("{0}からようこそ", student.country); };

            Console.WriteLine("input your name");
            string name = Console.ReadLine();

            List<Student> students = new List<Student>();

            var student1 = new Student();
            student1.id = "1";
            student1.name = "山田太郎";
            student1.country = "滋賀";
            students.Add(student1);
            Student student2 = new Student();
            student2.id = "2";
            student2.name = "高木次郎";
            student2.country = "京都";
            students.Add(student2);
            Student student3 = new Student();
            student3.id = "3";
            student3.name = "鈴木三郎";
            student3.country = "大阪";
            students.Add(student3);
            Student student4 = new Student();
            student4.id = "4";
            student4.name = "田中花子";
            student4.country = "奈良";
            students.Add(student4);
            Student student5 = new Student();
            student5.id = "5";
            student5.name = "石田森子";
            student5.country = "兵庫";
            students.Add(student5);

            foreach (Student oneStudent in students)
            {
                if (oneStudent.name == name)
                {
                    afterInputNameActions(oneStudent);
                }
            }
        }
    }

}
