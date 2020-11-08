using System.ComponentModel;
using Xamarin.Forms;
using CommandDisable.ViewModels;

namespace CommandDisable.Views
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