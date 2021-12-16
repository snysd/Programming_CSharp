using System;
using System.Collections.Generic;

namespace Programming_CSharp
{
        public class Student
    {
        public string id;
        public string name;
        public string country;
        public Action<string> MorningRoutine;

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            string nowString = DateTime.Now.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            Console.WriteLine(nowString);

            var nowStringEng = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            DateTime nowDateTime = DateTime.Parse(nowStringEng);
            Console.WriteLine(nowDateTime);

            int birthday = int.Parse(Console.ReadLine());
            var thisYear = DateTime.Now.Year;
            Console.WriteLine(thisYear - birthday);



        }
    }

}
