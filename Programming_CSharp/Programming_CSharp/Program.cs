using System;

namespace Programming_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ユーザ名を入力:");
            UserInfo.userName = Console.ReadLine();
            Console.Write("パスワードを入力:");
            UserInfo.password = Console.ReadLine();

            Console.Write("ユーザ名を再入力:");
            var userNameIn = Console.ReadLine();
            Console.Write("パスワードを再入力:");
            var passwordIn = Console.ReadLine();
            
            if(userNameIn == UserInfo.userName 
            && passwordIn == UserInfo.password)
            {
                Console.WriteLine("ログインしました");
            }
            else
            {
                Console.WriteLine("間違っています");
            }
        }
    }
    static class UserInfo
    {
        public static string userName, password;
    }
}
