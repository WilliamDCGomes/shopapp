using System;

using Xamarin.Forms;

namespace ShopApp
{
    public class Menu : ContentPage
    {
        public Menu()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

