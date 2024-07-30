using System;
using Microsoft.Maui.Controls;

namespace software
{
    public partial class CadastrodeCliente : ContentPage
    {
        public CadastrodeCliente()
        {
            InitializeComponent();
        }

        private void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string dataNascimento = DataNascimentoEntry.Text;
            string cpf = CPFEntry.Text;
            string numero = NumeroEntry.Text;
            string endereco = EnderecoEntry.Text;
            string email = EmailEntry.Text;

            // Aqui você pode adicionar a lógica para processar os dados do formulário

            DisplayAlert("Dados Confirmados", 
                         $"Nome: {nome}\nData de Nascimento: {dataNascimento}\nCPF: {cpf}\nNúmero: {numero}\nEndereço: {endereco}\nEmail: {email}", 
                         "OK");
        }
    }
}
