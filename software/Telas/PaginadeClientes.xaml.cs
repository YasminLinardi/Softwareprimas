using System.Collections.ObjectModel;

namespace software
{
    public partial class PaginadeClientes : ContentPage
    {
        public ObservableCollection<Cliente> Clientes { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Clientes = new ObservableCollection<Cliente>
            {
                new Cliente { Nome = "Cliente sobrenome" },
                new Cliente { Nome = "Cliente sobrenome" },
                new Cliente { Nome = "Cliente sobrenome" },
                // Adicione mais clientes conforme necessário
            };
            ClientesCollectionView.ItemsSource = Clientes;
        }

        private async void OnEditButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var cliente = button.BindingContext as Cliente;
            if (cliente != null)
            {
                // Navegar para a página de edição (implemente a página de edição conforme necessário)
                await Navigation.PushAsync(new EditarClientePage(cliente));
            }
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var cliente = button.BindingContext as Cliente;
            if (cliente != null)
            {
                Clientes.Remove(cliente);
            }
        }

        private async void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Adicionar novo cliente (implemente a lógica conforme necessário)
            await DisplayAlert("Adicionar Cliente", "Adicionar novo cliente", "OK");
        }
    }

    public class Cliente
    {
        public string Nome { get; set; }
    }
}
