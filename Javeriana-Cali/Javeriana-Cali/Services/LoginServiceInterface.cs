using System;
using JaverianaCali.Models;

namespace JaverianaCali.Services
{
    public interface LoginServiceInterface
    {
        UserModel validateCredentials(LoginModel loginModel);
    }
}
