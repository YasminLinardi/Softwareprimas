using Microsoft.Maui.Controls;

namespace software
    public partial class Cadastrodeprodutos : ContentPage
    {
        public ProductRegistrationPage()
        {
            InitializeComponent();
        }

        private void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string valor = ValorEntry.Text;

            // Lógica para salvar os dados do produto
            DisplayAlert("Dados do Produto", 
                         $"Nome: {nome}\nValor: {valor}", 
                         "OK");
        }
    }
}
