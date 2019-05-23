using System;
using System.Collections.Generic;
using JaverianaCali.ViewModels;
using Xamarin.Forms;

namespace JaverianaCali.Views
{
    public partial class LoginView : ContentPage
    {
        LoginViewModel context;

        public LoginView()
        {
            InitializeComponent();

            context = new LoginViewModel(this);
            BindingContext = context;
        }
    }
}
