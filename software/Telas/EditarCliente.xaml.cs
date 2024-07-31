namespace software
{
    public partial class EditarCliente : ContentPage
    {
        private Cliente _cliente;

        public EditarClientePage(Cliente cliente)
        {
            InitializeComponent();
            _cliente = cliente;
            BindingContext = _cliente;
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Salvar as mudanças do cliente
            _cliente.Nome = NomeEntry.Text;
            await Navigation.PopAsync();
        }
    }
}
