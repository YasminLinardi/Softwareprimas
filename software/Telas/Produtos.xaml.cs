using System;
using Microsoft.Maui.Controls;

namespace software
{
    public partial class Produtos : ContentPage
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private async void OnProductClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string productName = button.Text.Split('\n')[0]; // Extrair o nome do produto
            string result = await DisplayPromptAsync("Adicionar ao Carrinho", $"Deseja adicionar {productName} ao carrinho?", "Sim", "Não", "Quantidade", "Digite a quantidade", keyboard: Keyboard.Numeric);
            if (result != null)
            {
                // Adicionar lógica para adicionar ao carrinho
            }
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            // Navegar para a página do carrinho
            await Navigation.PushAsync(new CartPage());
        }
    }
}
