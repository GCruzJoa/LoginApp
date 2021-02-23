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
        public string NameSignUp { get; set; }
        public string EmailSignUp { get; set; }
        public string PasswordSignUp { get; set; }
        public string ConfirmPassSignUp { get; set; }
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
            if (PasswordSignUp != ConfirmPassSignUp)
            {
                await App.Current.MainPage.DisplayAlert("Alerta", "Las contraseñas deben ser iguales", "Cerrar");
            }
            if (!CheckInfoSignUp() && PasswordSignUp == ConfirmPassSignUp)
            {
                await App.Current.MainPage.DisplayAlert("Bienvenido", "Hola " + NameSignUp, "Cerrar");
                await App.Current.MainPage.Navigation.PushModalAsync(new TabbedHomePage());
            }
        }
        private bool CheckInfoSignUp()
        {
            if (string.IsNullOrEmpty(NameSignUp) || string.IsNullOrEmpty(EmailSignUp) || string.IsNullOrEmpty(PasswordSignUp))
                return true;
            else return false;
        }
    }
}
