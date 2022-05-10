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
    public partial class PrimeiroANO : ContentPage
    {
        public PrimeiroANO()
        {
            InitializeComponent();
        }

        // Manipulador de eventos criado para o botão ter uma função ao ser clicado
        private void Button_Clicked(object sender, EventArgs e)
        {
            // Através do Navigation, sempre que o úsuario clicar no botão, será redirecionado para a tela "PortuguesPrimeiro"
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        // A mesma coisa para todos os manipuladores abaixo, vão redirecionar para suas respectivas telas
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatematicaPrimeiro());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fisica());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaPrimeiro());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaPrimeiro());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EdFisicaPrimeiro());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaPrimeiro());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaPrimeiro());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaPrimeiro());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArtesPrimeiro());
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DesignDigital());
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProWEB1());
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BDados1());
        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AnalEProjetos());
        }

        private void Button_Clicked_14(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FundamentosInfo());
        }

        private void Button_Clicked_15(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Algoritimo());
        }

        private void Button_Clicked_16(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EdFisicaPrimeiro());
        }
    }
}