using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace software
{
    public partial class PaginadeFuncionarios : ContentPage
    {
        public ObservableCollection<Funcionario> Funcionario { get; set; }

        public PaginadeFuncionarios()
        {
            InitializeComponent();

            Funcionario = new ObservableCollection<Funcionario>
            {
                new Funcionario { Name = "Funcionário" },
                new Funcionario { Name = "Funcionário" },
                // Adicione mais funcionários conforme necessário
            };

            EmployeesListView.ItemsSource = Employees;
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var Funcionario = button?.BindingContext as Funcionario;

            if (Funcionario != null)
            {
                // Navegue para a página de edição de funcionários
                Navigation.PushAsync(new PaginadeFuncionarios(Funcionario));
            }
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var Funcionario = button?.BindingContext as Funcionario;

            if (Funcionario != null)
            {
                Funcionario.Remove(Funcionario);
            }
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Adicione a lógica para adicionar um novo funcionário
            Funcionario.Add(new Funcionario { Name = "Novo Funcionário" });
        }
    }

    public class Funcionario
    {
        public string Name { get; set; }
    }
}
