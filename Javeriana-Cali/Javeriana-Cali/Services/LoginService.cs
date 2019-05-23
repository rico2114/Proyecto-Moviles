using System;
using JaverianaCali.Models;

namespace JaverianaCali.Services
{
    public class LoginService : LoginServiceInterface {

        public LoginService() {
        }

        public UserModel validateCredentials(LoginModel loginModel)
        {
            if (loginModel.Username == "Juan2114")
            {
                return new UserModel(8912532, loginModel.Username, "Juan Sebastian", "Quiceno");
            }
            return null;
        }
    }
}
