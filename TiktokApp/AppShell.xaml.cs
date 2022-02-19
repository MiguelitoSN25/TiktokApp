using System;
using System.Collections.Generic;
using TiktokApp.ViewModels;
using TiktokApp.Views;
using Xamarin.Forms;

namespace TiktokApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
