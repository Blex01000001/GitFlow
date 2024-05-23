using GitFlow.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitFlow.Models;
using GitFlow.Services;

namespace GitFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入使用者姓名：");
            String UserName = Console.ReadLine();
            Console.WriteLine("請輸入使用者帳號：");
            String Account = Console.ReadLine();
            Console.WriteLine("請輸入使用者密碼：");
            String Password = Console.ReadLine();
            Console.WriteLine("請輸入使用者地址：");
            String Address = Console.ReadLine();

            User user = new User(UserName, Account, Password, Address);
            RegisterService service = new RegisterService();

            if (service.Register(user))
                Console.WriteLine("登入成功");
            else
            {
                Console.WriteLine("登入失敗");
            }
            SigninService signinservice = new SigninService();

            Console.ReadKey();

            //Hotfix/登入使用者收不到認證信
        }
    }
}
