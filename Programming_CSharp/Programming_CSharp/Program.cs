using System;
using System.IO;     //ファイル操作
using System.Text;　 //高度な文字処理


namespace Programming_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Programming\SRC\Programming_CSharp\Programming_CSharp\Test.txt");
            string str = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine(str);
        }
    }
}
