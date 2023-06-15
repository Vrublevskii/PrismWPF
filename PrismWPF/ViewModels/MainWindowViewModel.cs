using Prism.Commands;
using Prism.Mvvm;
using PrismWPF.Views;
using System.Windows;

namespace PrismWPF.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Сотрудники";
        private string _comboBoxSelectedValue;
        private string _searchVariable;
        private DelegateCommand _searchClickCommand;
        private DelegateCommand _advancedSearchCommand;
        private DelegateCommand _addClick;
        private DelegateCommand _exportExcelClick;
        private DelegateCommand _exportPDFClick;

        IViewAdd _viewAdd;
        IViewAdvancedSearch _viewAdvancedSearch;

        public MainWindowViewModel(IViewAdd viewAdd, IViewAdvancedSearch viewAdvancedSearch)
        {
            _viewAdd = viewAdd;
            _viewAdvancedSearch = viewAdvancedSearch;
        }


        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ComboBoxSelectedValue
        {
            get { return _comboBoxSelectedValue; }
            set { SetProperty(ref _comboBoxSelectedValue, value); }
        }

        public string SearchVariable
        {
            get { return _searchVariable; }
            set { SetProperty(ref _searchVariable, value); }
        }




        public DelegateCommand SearchClick =>
           _searchClickCommand ?? (_searchClickCommand = new DelegateCommand(ExecuteSearchClick));
        
        public DelegateCommand AdvancedSearchClick =>
           _advancedSearchCommand ?? (_advancedSearchCommand = new DelegateCommand(ExecuteAdvancedSearchClick));

        public DelegateCommand AddClick =>
           _addClick ?? (_addClick = new DelegateCommand(ExecuteAddClick));

        public DelegateCommand ExportExcelClick =>
                   _exportExcelClick ?? (_exportExcelClick = new DelegateCommand(ExecuteExportExcelClick));

        public DelegateCommand ExportPDFClick =>
                   _exportPDFClick ?? (_exportPDFClick = new DelegateCommand(ExecuteExportPDFClick));

        

        void ExecuteSearchClick()
        {
            MessageBox.Show($"Search {_searchVariable} {_comboBoxSelectedValue}");
        }
        
        void ExecuteAdvancedSearchClick()
        {
            _viewAdvancedSearch.Open();
        }

        void ExecuteAddClick()
        {
            _viewAdd.Open();
        }

        void ExecuteExportExcelClick()
        {
            MessageBox.Show($"Export excel");
        }
        void ExecuteExportPDFClick()
        {
            MessageBox.Show($"Export PDF");
        }

    }
}
