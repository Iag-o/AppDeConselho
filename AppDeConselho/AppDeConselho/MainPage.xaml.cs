using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppDeConselho.Model;
using AppDeConselho.Services;

namespace AppDeConselho
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

            var Image = new Image { Source = "fundo.jpg" };

            this.Title = "Concelho da mesa";

            this.BindingContext = new Mensagem();
        }

        private async void bntMensagem_Clicked(object sender, EventArgs e)
        {

            try
            {
                Mensagem conselho = await DataService.GetMensagem();
                this.BindingContext = conselho;
                bntMensagem.Text = "Novo Conselho";
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "ok");
            }

        }
    }
}
