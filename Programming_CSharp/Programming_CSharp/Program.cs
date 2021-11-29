using System;
using System.IO;     //ファイル操作
using System.Text;　 //高度な文字処理


namespace Programming_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new StreamWriter(@"C:\Programming\SRC\Programming_CSharp\Programming_CSharp\Test.txt",false);

            writer.WriteLine("この内容を書き込みます。");

            writer.Close();

        }
    }
}
