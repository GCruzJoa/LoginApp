using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Login_App.ViewModels;

namespace Login_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedHomePage : TabbedPage
    {
        public TabbedHomePage()
        {
            InitializeComponent();
            BindingContext = new TabbedHomeViewModel();
        }
    }
}