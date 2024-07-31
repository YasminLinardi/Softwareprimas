using Microsoft.Maui.Controls;

namespace software
{
    public partial class CadastrodeCargo : ContentPage
    {
        public CadastroCargosPage()
        {
            InitializeComponent();
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;

            if (!string.IsNullOrWhiteSpace(nome))
            {
                // Lógica para salvar o nome do cargo
                await DisplayAlert("Sucesso", "Cargo cadastrado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Por favor, insira um nome para o cargo.", "OK");
            }
        }
    }
}
