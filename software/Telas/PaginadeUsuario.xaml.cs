using Microsoft.Maui.Controls;
using Modelos;

namespace software
{
    public partial class UsuarioPage : ContentPage
    {
        public UsuarioPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string nome = UserNameLabel.Text;
            string telefone = UserPhoneLabel.Text;
            string endereco = UserAddressLabel.Text;
            string email = UserEmailLabel.Text;

            DisplayAlert("Sucesso", "Perfil atualizado com sucesso!", "OK");
        }
        async void OnDeleteButtonClicked(object sender, EventArgs args)
        {
            var resp = await DisplayAlert ("APAGAR" , "Certeza que deseja apagar este usuário?" , "SIM" , "NÃO"); 
          // if (resp == "SIM")
           {

           }
        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PaginadeFornecedor();
        } 
        private void OnEditButtonClicked(object sender, EventArgs e)
        {
           Application.Current.MainPage = new CadastroFornecedores();
        }

    }
}