using Prism.Ioc;
using Prism.Modularity;
using PrismWPF.Views;
using System.Windows;

namespace PrismWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IViewAdvancedSearch, AdvancedSearch>();
            containerRegistry.Register<IViewAdd, AddEmployee>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
        }

    }
}
