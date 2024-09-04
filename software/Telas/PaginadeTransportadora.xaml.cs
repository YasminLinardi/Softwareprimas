using Modelos;

namespace software
{
    public partial class PaginadeTransportadora : ContentPage
    {
        Controles.TransportadoraControle transportadoraControle = new Controles.TransportadoraControle();
        public PaginadeTransportadora()
        {
            InitializeComponent();
            ListaTransportadora.ItemsSource = transportadoraControle.LerTodos();
        }

         void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new TransportadoraCadastroPage();
            page.transportadora = e.SelectedItem as Transportadora;
            Application.Current.MainPage = page;
        }
        private void Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }
        private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TransportadoraCadastroPage();
        }
    }
}