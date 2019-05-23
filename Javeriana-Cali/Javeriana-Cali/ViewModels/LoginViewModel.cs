using System;
using System.Threading.Tasks;
using JaverianaCali.Models;
using JaverianaCali.Services;
using JaverianaCali.Views;
using Xamarin.Forms;

namespace JaverianaCali.ViewModels
{
    public class LoginViewModel : LoginModel {
        private LoginService loginService = new LoginService();

        private ContentPage contentPage;
        private bool isBussy;

        public LoginViewModel(ContentPage contentPage) {
            this.contentPage = contentPage;
            // This is used only to test if the extended class atributes are being displayed correctly
            this.Username = "Juan2114";
            this.Password = "abc";

            LoginCommand = new Command(async () => await Login(), () => !isBussy);
        }

        public Command LoginCommand { get; set; }

        private async Task Login() {
            isBussy = true;
            UserModel user = loginService.validateCredentials(this);
            if (user == null) {
                // Pop up with invalid password (I assume you have to use await in this line)
            } else {
                await contentPage.Navigation.PushAsync(new CoursesView(user));
            }
            isBussy = false;
        }
    }
}
