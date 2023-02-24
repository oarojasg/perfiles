using System;
using System.Collections.Generic;
using Perfiles.ViewModels;
using Xamarin.Forms;

namespace Perfiles.Views
{
    public partial class buscarPage : ContentPage
    {
        public buscarPage()
        {
            InitializeComponent();

            BindingContext = new PerfilViewModel();
        }
    }
}
