using Fluxograma;

namespace software
{
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

         private void Cliente(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Paginadeclientes();
        }

         private void Fornecedor(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PaginadeFornecedor();
        }

        private void Produto(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PaginadeProduto();
        }

        private void MateriaPrima(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PaginadeMateriaPrima();
        }

        private void Transportadora(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PaginadeTransportadora();
        }

        private void Funcionarios(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PaginadeFuncionarios();
        }

        private void Estoque(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PaginadeEstoque();
        }
    }
}
