using PrismWPF.Constants;
using System.ComponentModel;
using System.Windows;

namespace PrismWPF.Views
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window, IViewAdd
    {
        public AddEmployee()
        {
            InitializeComponent();
            department.ItemsSource = DBResultColumns.Departments;
            position.ItemsSource = DBResultColumns.Positions;
        }

        public bool? Open()
        {
            return ShowDialog();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Visibility = Visibility.Collapsed;
            e.Cancel = true;
        }
    }
    public interface IViewAdd
    {
        bool? Open();
    }
}
