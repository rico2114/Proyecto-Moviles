using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JaverianaCali.Models;
using JaverianaCali.ViewModels;
using Xamarin.Forms;

namespace JaverianaCali.Views
{
    public partial class LoginView : ContentPage
    {
        private LoginViewModel context;

        public LoginView()
        {
            InitializeComponent();
            context = new LoginViewModel();
            BindingContext = context;
        }

        private void ClickedLogin(object sender, EventArgs args) {
            UserModel user = context.AttemptLogin();
            if (user == null) {
                // Invalid user attempted to log in :)
                DisplayAlert("Autenticacion fallida", "Datos de inicio incorrectos", "OK");
            } else {
                Navigation.PushAsync(new CoursesView(user));
            }
        }
    }
}
