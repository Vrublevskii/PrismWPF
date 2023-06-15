using Prism.Mvvm;

namespace PrismWPF.ViewModels
{
    public class AddEmployeeViewModel : BindableBase
    {

        private string _title = "Добавить запись";



        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        

    }
}
