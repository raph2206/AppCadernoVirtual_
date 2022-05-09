using AppCadernoVirtual.Primeiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCadernoVirtual
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_17(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroANO());
        }

        private void Button_Clicked_18(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoANO());
        }

        private void Button_Clicked_19(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroANO());
        }
    }
}
