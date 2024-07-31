using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace software
{
    public partial class PaginadeFuncionarios : ContentPage
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public EmployeesPage()
        {
            InitializeComponent();

            Employees = new ObservableCollection<Employee>
            {
                new Employee { Name = "Funcionário" },
                new Employee { Name = "Funcionário" },
                // Adicione mais funcionários conforme necessário
            };

            EmployeesListView.ItemsSource = Employees;
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var employee = button?.BindingContext as Employee;

            if (employee != null)
            {
                // Navegue para a página de edição de funcionários
                Navigation.PushAsync(new EditEmployeePage(employee));
            }
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var employee = button?.BindingContext as Employee;

            if (employee != null)
            {
                Employees.Remove(employee);
            }
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Adicione a lógica para adicionar um novo funcionário
            Employees.Add(new Employee { Name = "Novo Funcionário" });
        }
    }

    public class Employee
    {
        public string Name { get; set; }
    }
}
