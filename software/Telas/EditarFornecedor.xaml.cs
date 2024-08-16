    using Microsoft.Maui.Controls;
using Modelos;

namespace software
{
    public partial class EditarFornecedor : ContentPage
    {
        private Fornecedores fornecedor;

        public EditarFornecedor(Fornecedor fornecedor)
        {
            InitializeComponent();

            fornecedor = Fornecedores;
            BindingContext = Fornecedores;
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

}
