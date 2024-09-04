using Microsoft.Maui.Controls;

namespace fluxograma
{
    public partial class PaginadeEstoque : ContentPage
    {
        public PaginadeEstoque()
        {
            InitializeComponent();
        }

        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }

        private void Compra(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PaginadeCompras();
        }
    }

    internal class TelaInicial : Page
    {
    }
}
