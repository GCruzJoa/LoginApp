using Login_App.Models;
using Login_App.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Login_App.ViewModels
{
    public class LoginViewModel
    {
        public ICommand LoginCommand { get; }
        public ICommand SignUpCommand { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
            SignUpCommand = new Command(OnSignUp);
        }

        private async void OnLogin()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Alerta", "Campo Email y/o contraseña no puede estar vacío", "Cerrar");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Bienvenido", "Hola " + Email, "Cerrar");
            }
        }
        private async void OnSignUp()
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new SignUpPage());
        }
    }
}
