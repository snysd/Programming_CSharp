using System;

namespace Programming_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("名前を入力してください");
            var userName = Console.ReadLine();
            Console.WriteLine("パスワードを入力してください");
            var userPassword = Console.ReadLine();
            bool x = false;
            string falseReason = "";

            do
            {
                Console.WriteLine("もう一度名前を入力してください");
                var userNameVerify = Console.ReadLine();
                Console.WriteLine("もう一度パスワードを入力してください");
                var userPasswordVerify = Console.ReadLine();
                x = JudgedVerify(userName, userNameVerify,
                    userPassword, userPasswordVerify, ref falseReason);
                if (x == false)
                {
                    Console.WriteLine($"{falseReason}が間違っています");
                    continue;
                }

            } while (x == false);

            Console.WriteLine("ログイン成功");
        }

        static bool JudgedVerify(string userName,string userNameVerify, 
            string userPassword, string userPasswordVerify, ref string falseReason)
        {
            bool returnBooleanValue;

            if (userName != userNameVerify)
            {
                returnBooleanValue = false;
                falseReason = "名前";
            }
            else if (userPassword != userPasswordVerify)
            {
                returnBooleanValue = false;
                falseReason = "パスワード";
            }
            else
            {
                returnBooleanValue = true;
            }
            return returnBooleanValue;
        }
    }
}
