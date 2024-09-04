using Controles;
using Modelos;


namespace software
{
    public partial class CadastrodeMateriaPrima : ContentPage
    {
        public Materia materia { get; set; }
        Controles.MateriaControle MateriaControle = new Controles.MateriaControle();
        Controles.UnidadeControle UnidadeControle = new Controles.UnidadeControle();

        public CadatrodeMateriaPrima()
        {
            InitializeComponent();
        }

                protected override void OnAppearing()
        {
            base.OnAppearing();
            if (materia != null)
            {
                NomeEntry.Text = materia.Nome;
                //ValorEntry.Text = materia.Valor;
                LabelId.Text = materia.Id.ToString();
                

            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs args)
        {
             if (await VerificaDados())
         {
                var materia = new Modelos.Materia();

                materia.Id = 0;
                materia.Nome = NomeEntry.Text;
                //materia.Valor = ValorEntry.Text;
                
                MateriaControle.CriarOuAtualizar(materia);

                await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            
        }
       }

        private async Task<bool> VerificaDados()
        {
            if (String.IsNullOrEmpty(NomeEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            
            else
                return true;
        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PaginadeMateriaPrima();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs args)
        {
             if (materia != null)
            {
            var resp = await DisplayAlert("APAGAR", "Certeza que deseja apagar este usuário?", "SIM", "NÃO");
            if (resp)
            {
                MateriaControle.Apagar(materia.Id);
                Application.Current.MainPage = new PaginadeMateriaPrima();
            }
            }
        }
    }
}





    
