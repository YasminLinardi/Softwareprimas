using Controles;
using Modelos;

namespace software
{
    public partial class PaginadeProdutos : ContentPage
    {
        public Produtos Produtos { get; set; }
        Controles.ProdutosControle produtoControle = new Controles.ProdutosControle();
        public PaginadeProdutos()
        {
            InitializeComponent();
            ListaProduto.ItemsSource = ProdutosControle.LerTodos();
        }

       void QuandoSelecionarUmItem(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CadastrodeProdutos();
            page.Produtos = e.SelectedItem as Produtos;
            Application.Current.MainPage = page;
        }

        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }

        private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Cadastrodeprodutos();
        }
    }
}