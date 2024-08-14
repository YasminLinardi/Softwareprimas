using Telas;

namespace software
{
    public partial class PaginadeFornecedor : ContentPage
    {
        public ObservableCollection<Fornecedor> Fornecedor { get; set; }

        public PaginadeFornecedor()
        {
            InitializeComponent();
            Clientes = new ObservableCollection<Fornecedor>
            {
                new Cliente { Nome = "Fornecedor" },
                new Cliente { Nome = "Fornecedor" },
                new Cliente { Nome = "Fornecedor" },
                // Adicione mais Fornecedor conforme necessário
            };
            ClientesCollectionView.ItemsSource = Fornecedores;
        }

        private async void OnEditButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var Fornecedor = button.BindingContext as Fornecedor;
            if (Fornecedor != null)
            {
                // Navegar para a página de edição (implemente a página de edição conforme necessário)
                await Navigation.PushAsync(new EditarClientePage(Fornecedor));
            }
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var Fornecedor = button.BindingContext as Fornecedor;
            if (Fornecedor != null)
            {
                Fornecedor.Remove(Fornecedor);
            }
        }

        private async void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Adicionar novo Fornecedor (implemente a lógica conforme necessário)
            await DisplayAlert("Adicionar Fornecedor", "Adicionar novo Forncedor", "OK");
        }
    }

    public class Fornecedor
    {
        public string Nome { get; set; }
    }
}