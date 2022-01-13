using DogGO.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DogGO.Views
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