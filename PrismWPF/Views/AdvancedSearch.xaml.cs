using PrismWPF.Constants;
using System.ComponentModel;
using System.Windows;

namespace PrismWPF.Views
{
    /// <summary>
    /// Interaction logic for AdvancedSearch.xaml
    /// </summary>
    public partial class AdvancedSearch : Window, IViewAdvancedSearch
    {
        public AdvancedSearch()
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
    public interface IViewAdvancedSearch
    {
        bool? Open();
    }
}
