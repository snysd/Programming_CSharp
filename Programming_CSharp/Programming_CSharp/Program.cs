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
            int i = 0;


            do
            {

                Console.WriteLine("もう一度名前を入力してください");
                var userNameVerify = Console.ReadLine();
                Console.WriteLine("もう一度パスワードを入力してください");
                var userPasswordVerify = Console.ReadLine();

                if (userName != userNameVerify)
                {
                    Console.WriteLine("名前が間違っています");
                }
                else if (userPassword != userPasswordVerify)
                {
                    Console.WriteLine("パスワードが間違っています");
                }
                else
                {
                    Console.WriteLine("ログイン成功");
                    i = 1;
                }

            } while (i == 0);
        }
    }
}
