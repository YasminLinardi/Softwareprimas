using Microsoft.Maui.Controls;

namespace software
{
    public partial class CadastrodeFuncionarios : ContentPage
    {
        public CadastrodeFuncionarios()
        {
            InitializeComponent();
        }

        private void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            // Lógica para tratar o clique do botão de confirmação
            string nome = NomeEntry.Text;
            string dataNascimento = DataNascimentoEntry.Text;
            string cpf = CPFEntry.Text;
            string numero = NumeroEntry.Text;
            string endereco = EnderecoEntry.Text;
            string cargo = CargoPicker.SelectedItem?.ToString();

            // Exemplo de exibição dos dados
            DisplayAlert("Dados Cadastrados", 
                         $"Nome: {nome}\nData de Nascimento: {dataNascimento}\nCPF: {cpf}\nNúmero: {numero}\nEndereço: {endereco}\nCargo: {cargo}", 
                         "OK");
        }
    }
}
