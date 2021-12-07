using System;
using System.Collections.Generic;
using System.ComponentModel;
using WebServiceTutorial.Models;
using WebServiceTutorial.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebServiceTutorial.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}