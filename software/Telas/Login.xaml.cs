using Microsoft.Maui.Controls;

namespace software
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            // Coloque aqui o que você deseja fazer quando o botão for clicado.
            DisplayAlert("Login", $"Nome do usuário: {username}", "OK");
        }
    }
}

