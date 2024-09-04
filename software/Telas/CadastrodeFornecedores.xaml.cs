using Microsoft.Maui.Controls;

namespace software
{
    public partial class CadastroFornecedores : ContentPage
    {
        public CadastroFornecedores()
        {
            InitializeComponent();
        }

        private async void OnClienteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginadeClientes ());
        }

        private async void OnFornecedoresClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginadeFornecedor());
        }

        private async void OnMateriaPrimaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginadeMateriaPrima());
        }

        private async void OnProdutosClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginadeProdutos());
        }

        private async void OnFuncionariosClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginadeFuncionarios());
        }

        private async void OnVendasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginadeVendas());
        }

        private async void OnCargosClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginadeCargos());
        }
    }
}
