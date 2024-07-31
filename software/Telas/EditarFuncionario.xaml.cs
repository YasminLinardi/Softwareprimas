using Microsoft.Maui.Controls;

namespace software
{
    public partial class EditarFuncionario : ContentPage
    {
        private Employee _employee;

        public EditEmployeePage(Employee employee)
        {
            InitializeComponent();

            _employee = employee;
            BindingContext = _employee;
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Volta para a página anterior após salvar
            Navigation.PopAsync();
        }
    }
}
