using System.Windows;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using SMBS.BAL.Container;
using SMBS.BAL.Mvvm;
using SMBS.Views;

namespace SMBS
{
    /// <summary`>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static readonly WindsorContainer Container = new WindsorContainer();

        public App()
        {
            Container.AddFacility<WindowActivatorFacility>();
            Container.Register(
                Types.FromThisAssembly().BasedOn<IView>().Configure(x => x.LifestyleTransient()),
                Types.FromThisAssembly().BasedOn<IViewModel>().Configure(c => c.LifestyleTransient())
            );
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var main = Container.Resolve<ShellView>();
            main.ShowDialog();
        }
    }
}
