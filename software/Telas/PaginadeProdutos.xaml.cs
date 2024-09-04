using Controles;
using Modelos;

namespace software
{
    public partial class ProdutoPage : ContentPage
    {
        public Produtos Produto { get; set; }
        Controles.ProdutosControle produtoControle = new Controles.ProdutosControle();
        public ProdutoPage()
        {
            InitializeComponent();
            ListaProduto.ItemsSource = produtoControle.LerTodos();
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
            Application.Current.MainPage = new CadastrodeProdutos();
        }
    }
}