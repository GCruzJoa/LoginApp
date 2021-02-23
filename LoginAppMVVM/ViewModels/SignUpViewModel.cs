using Login_App.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Login_App.ViewModels
{
    class SignUpViewModel
    {
        public ICommand OnSignUpCommand { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public SignUpViewModel()
        {
            OnSignUpCommand = new Command(OnSignUpTapped);
        }
        private async void OnSignUpTapped()
        {
            if (CheckInfoSignUp())
            {
                await App.Current.MainPage.DisplayAlert("Alerta", "Debe completar todos los campos", "Cerrar");
            }
            if (Password != ConfirmPassword)
            {
                await App.Current.MainPage.DisplayAlert("Alerta", "Las contraseñas deben ser iguales", "Cerrar");
            }
            if (!CheckInfoSignUp() && Password == ConfirmPassword)
            {
                await App.Current.MainPage.DisplayAlert("Bienvenido", "Hola " + Name, "Cerrar");
                await App.Current.MainPage.Navigation.PushModalAsync(new TabbedHomePage());
            }
        }
        private bool CheckInfoSignUp()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                return true;
            else return false;
        }
    }
}
