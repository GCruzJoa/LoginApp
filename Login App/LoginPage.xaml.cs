using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginScreen : ContentPage
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        void LoginClicked(object sender, EventArgs e)
        {
            User user = new User(E1.Text, E2.Text);
            if (user.CheckInfoLogin())
            {
                DisplayAlert("Alerta", "Campo Email y/o contraseña no puede estar vacío", "Cerrar");
            }
            else
            {
                DisplayAlert("Bienvenido", "Hola "+ user.Email, "Cerrar");
            }
        }

        void RegistroClicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new RegistroPage());
        }
    }
}