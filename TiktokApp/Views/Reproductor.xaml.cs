using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiktokApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reproductor : ContentPage
    {
        public Reproductor()
        {
            InitializeComponent();
            rvideo.Source = "https://firebasestorage.googleapis.com/v0/b/tiktokapp-d7b69.appspot.com/o/descargar.mp4?alt=media&token=84ee1798-7013-4bfd-ae2f-0354555280e1";
        }
    }
}