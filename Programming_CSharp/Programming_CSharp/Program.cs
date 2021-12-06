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
            // ディクショナリの宣言
            var dic = new Dictionary<string, int>();
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("ユーザー名とパスワードを入力");
                var userName = Console.ReadLine();
                var password = Int32.Parse(Console.ReadLine());
                dic.Add(userName, password);
            }

            while (true)
            {
                Console.WriteLine("ユーザー名とパスワードを再入力");
                var userName1 = Console.ReadLine();
                var password1 = Int32.Parse(Console.ReadLine());
                if (dic.ContainsKey(userName1) && dic[userName1] == password1)
                {
                    Console.WriteLine("ログイン成功");

                    break;
                }
            }
        }
    }
   
}
