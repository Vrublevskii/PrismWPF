using Prism.Mvvm;

namespace PrismWPF.ViewModels
{
	public class AdvancedSearchViewModel : BindableBase
	{
        private string _title = "Продвинутый поиск";




        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }






    }
}
