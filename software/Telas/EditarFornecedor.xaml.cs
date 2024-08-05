    using Microsoft.Maui.Controls;

namespace software
{
    public partial class EditarFornecedor : ContentPage
    {
        private Fornecedor _fornecedor;

        public EditarFornecedor(Fornecedor fornecedor)
        {
            InitializeComponent();

            _fornecedor = fornecedor;
            BindingContext = _fornecedor;
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Lógica para salvar os dados do fornecedor
            // Você pode adicionar a lógica de persistência aqui, como salvar em um banco de dados

            DisplayAlert("Salvar", "As informações do fornecedor foram salvas com sucesso!", "OK");

            // Volta para a página anterior após salvar
            Navigation.PopAsync();
        }
    }

    public class Fornecedor
    {
        public string Name { get; set; }
    }
}
