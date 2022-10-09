using System.ComponentModel.DataAnnotations;

namespace AsuTask.Common
{
    public class AuthenticateRequestModel
    {
        public AuthenticateRequestModel(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; }

        public string Password { get; }
    }
}
