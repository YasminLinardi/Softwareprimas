using Microsoft.Maui.Controls;

namespace fluxograma
{
    public partial class EstoquePage : ContentPage
    {
        public EstoquePage()
        {
            InitializeComponent();
        }

        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }

        private void Compra(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ComprasPage();
        }
    }

    internal class TelaInicial : Page
    {
    }
}
