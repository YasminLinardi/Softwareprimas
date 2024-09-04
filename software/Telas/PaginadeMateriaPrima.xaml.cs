using Modelos;


namespace software
{
    public partial class PaginadeMateriaPrima : ContentPage
    {
        public Materia materia { get; set; }
        Controles.MateriaControle materiaControle = new Controles.MateriaControle();

        public PaginadeMateriaPrima()
        {
            InitializeComponent();
            ListaMateria.ItemsSource = MateriaControle.LerTodos();
        }

        void QuandoSelecionarUmItem(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CadastrodeMateriaPrima();
            page.materia = e.SelectedItem as Materia;
            Application.Current.MainPage = page;
        }

        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }

        private void Criar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastrodeMateriaPrima();
        }



}
}
    

