

using Perfiles.ViewModels;
using Xamarin.Forms;

namespace Perfiles.Views
{
    public partial class datosPage : ContentPage
    {
        public datosPage()
        {
            InitializeComponent();

            BindingContext = new PerfilViewModel();
        }
    }
}
