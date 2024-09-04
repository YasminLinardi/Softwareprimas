using Microsoft.Maui.Controls;

namespace software
{
    public partial class PaginadeCompras : ContentPage
    {

        public PaginadeCompras()
        {
            InitializeComponent();  
        }

          private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PaginadeEstoque();
        }
       
    }

}
