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

        // Manipulador de eventos criado para o botão ter uma função ao ser clicado
        private void Button_Clicked_17(object sender, EventArgs e)
        {
            // Através do Navigation, sempre que o úsuario clicar no botão, será redirecionado para a tela "PrimeiroANO", dando acesso a mais botões :/
            Navigation.PushAsync(new PrimeiroANO());
        }

        // A mesma coisa para os manipuladores abaixo, vão redirecionar para suas respectivas telas
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
