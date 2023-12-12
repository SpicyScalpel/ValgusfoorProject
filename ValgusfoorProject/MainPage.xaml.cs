using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ValgusfoorProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var valgus_btn = new Button
            {
                Text = "Valgusfoor",
                BackgroundColor = Color.Khaki
            };

            valgus_btn.Clicked += Valgus_btn_Clicked;

            Content = new StackLayout
            {
                Margin = 20,
                Children =
                {
                    valgus_btn
                }
            };
        }

        private async void Valgus_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ValgusfoorPage());
        }
    }
}