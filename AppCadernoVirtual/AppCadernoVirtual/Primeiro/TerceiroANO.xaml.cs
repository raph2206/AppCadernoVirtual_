using AppCadernoVirtual.Primeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual.Primeiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TerceiroANO : ContentPage
    {
        public TerceiroANO()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EdFisicaTerceiro());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaTerceiro());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesTerceiro());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesTerceiro());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatematicaTerceiro());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaTerceiro());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaTerceiro());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaTerceiro());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaTerceiro());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaTerceiro());
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SociologiaTerceiro());
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProWEB3());
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProMob2());
        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Internet());
        }

        private void Button_Clicked_14(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TCC());
        }

        private void Button_Clicked_15(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QualidadeTesteSoftware());
        }
    }
}