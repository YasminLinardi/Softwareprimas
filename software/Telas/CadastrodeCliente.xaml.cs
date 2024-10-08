using System;
using Microsoft.Maui.Controls;

namespace software
{
    public partial class CadastrodeCliente : ContentPage
  {
   public Cliente cliente { get; set; }
  Controles.ClienteControle clienteControle = new Controles.ClienteControle();


	public CadastrodeCliente()
	{
		InitializeComponent();
	}


  void VoltarClicked(object sender, EventArgs e)
  {
    Application.Current.MainPage = new ListadeClientes();
  }

  protected override void OnAppearing()
  {
    base.OnAppearing();

    if (cliente != null)
    {
      IdLabel.Text        = cliente.Id.ToString();
      NomeEntry.Text      = cliente.Nome;
      SobrenomeEntry.Text = cliente.Sobrenome;
      TelefoneEntry.Text  = cliente.Telefone;
    }
    }

  private void OnApagarDadosClicked(object sender, EventArgs e)
    {
    IdLabel.Text = string.Empty;
    NomeEntry.Text = string.Empty;
    SobrenomeEntry.Text = string.Empty;
    TelefoneEntry.Text = string.Empty;
    }


  private async void OnSalvarDadosClicked(object sender, EventArgs e)
    {
    if (await VerificaSeDadosEstaoCorretos())
      {
      var cliente = new Modelos.Cliente();
      if (!String.IsNullOrEmpty(IdLabel.Text))
        cliente.Id      = int.Parse(IdLabel.Text);
      else
        cliente.Id      = 0;
      cliente.Nome      = NomeEntry.Text;
      cliente.Sobrenome = SobrenomeEntry.Text;
      cliente.Telefone  = TelefoneEntry.Text;

      clienteControle.CriarOuAtualizar(cliente);
      await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
      }
    }

  private async Task<bool> VerificaSeDadosEstaoCorretos()
    {
    if (String.IsNullOrEmpty(NomeEntry.Text))
      {
      await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
        return false;
      }
      else if (String.IsNullOrEmpty(SobrenomeEntry.Text))
      {
      await DisplayAlert("Cadastrar", "O campo Sobrenome é obrigatório", "OK");
        return false;
      }
      else if (String.IsNullOrEmpty(TelefoneEntry.Text))
      {
      await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
        return false;
      }
      else
        return true;
    }

  }
    }

