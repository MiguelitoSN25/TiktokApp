using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TiktokApp.Views;
using TiktokApp.ViewModels;

namespace TiktokApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reproductor : ContentPage
    {
        public Reproductor()
        {
            InitializeComponent();
            BindingContext = new Vmreproductor(Navigation);
        }
    }
}