using GitFlow.Models;

namespace GitFlow.Services
{
    public class RegisterService
    {
        public bool Register(User model)
        {
            bool canRegister = HasAccount(model.Account);
            if (canRegister)
            {
                // 建立註冊流程
            }
            return true;
        }

        private bool HasAccount(string email)
        {
            if (email == "leo604leo604@gmail.com")
                return false;
            return true;
        }
    }
}