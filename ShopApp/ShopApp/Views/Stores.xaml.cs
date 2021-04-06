using System;
using System.Collections.Generic;
using ShopApp.ViewModels;
using Xamarin.Forms;

namespace ShopApp.Views
{
    public partial class Stores : ContentPage
    {
        public Stores()
        {
            InitializeComponent();
            BindingContext = new StoresViewModel();

        }
    }
}
