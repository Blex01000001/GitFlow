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
            //msater 1.0.0
            Console.WriteLine("請輸入使用者姓名：");
            String UserName = Console.ReadLine();
            Console.WriteLine("請輸入使用者帳號：");
            String Account = Console.ReadLine();
            Console.WriteLine("請輸入使用者密碼：");
            String Password = Console.ReadLine();
            Console.WriteLine("請輸入使用者地址：");
            String Address = Console.ReadLine();

            User user = new User();
            user.Name = UserName;
            user.Account = Account;
            user.Password = Password;
            user.Address = Address;

            RegisterService service = new RegisterService();

            bool isSuccess = service.Register(user);

            if (isSuccess)
                Console.WriteLine("登入成功");
            else
            {
                Console.WriteLine("登入失敗");
            }
            SigninService signinservice = new SigninService();

            Console.ReadKey();//
        }
    }
}
