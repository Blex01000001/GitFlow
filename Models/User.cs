namespace GitFlow.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public User(string name, string account, string password, string address)
        {
            Name = name;
            Account = account;
            Password = password;
            Address = address;
        }
    }
}