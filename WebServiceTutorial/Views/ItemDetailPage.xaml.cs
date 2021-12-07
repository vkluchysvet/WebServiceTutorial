using System.ComponentModel;
using WebServiceTutorial.ViewModels;
using Xamarin.Forms;

namespace WebServiceTutorial.Views
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