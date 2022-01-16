using Pacurar_Viorel_Lab12.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Pacurar_Viorel_Lab12.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}