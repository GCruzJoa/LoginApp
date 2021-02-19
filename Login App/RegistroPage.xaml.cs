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
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
        }

        void RegistrarClicked(object sender, EventArgs e)
        {
            User user = new User(E3.Text, E4.Text, E5.Text);
            if (user.CheckInfoRegistro())
            {
                DisplayAlert("Alerta", "Debe completar todos los campos", "Cerrar");
            }
            if (E5.Text != E6.Text)
            {
                DisplayAlert("Alerta", "Las contraseñas deben ser iguales", "Cerrar");
            }
            if (!user.CheckInfoRegistro() && E5.Text == E6.Text)
            {
                DisplayAlert("Bienvenido", "Hola " + user.Name, "Cerrar");
                this.Navigation.PushModalAsync(new HomePage());
            }            
        }
    }
}