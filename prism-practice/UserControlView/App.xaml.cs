using Prism.Ioc;
using System.Windows;
using UserControlView.Views;

namespace UserControlView
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
            containerRegistry.RegisterForNavigation<HugeLabelView>();
        }
    }
}
