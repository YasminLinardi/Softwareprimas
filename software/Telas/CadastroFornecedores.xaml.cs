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
            await Navigation.PushAsync(new ClientePage());
        }

        private async void OnFornecedoresClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FornecedoresPage());
        }

        private async void OnMateriaPrimaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MateriaPrimaPage());
        }

        private async void OnProdutosClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProdutosPage());
        }

        private async void OnFuncionariosClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FuncionariosPage());
        }

        private async void OnVendasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VendasPage());
        }

        private async void OnCargosClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CargosPage());
        }
    }
}
