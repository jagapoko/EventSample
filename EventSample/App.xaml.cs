using Prism.Ioc;
using EventSample.Views;
using System.Windows;
namespace EventSample
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
            containerRegistry.RegisterForNavigation<Views.CodeBehind>();
            containerRegistry.RegisterForNavigation<Views.Prism>();
            containerRegistry.RegisterForNavigation<Views.ReactiveProperty>();
        }
    }
}
