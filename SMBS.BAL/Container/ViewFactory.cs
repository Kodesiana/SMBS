using Castle.Windsor;
using SMBS.BAL.Mvvm;

namespace SMBS.BAL.Container
{
    public class ViewFactory : IViewFactory
    {
        private readonly IWindsorContainer _container;

        public ViewFactory(IWindsorContainer container)
        {
            _container = container;
        }
        
        public T CreateView<T>() where T : IView
        {
            return _container.Resolve<T>();
        }

        public T CreateView<T>(object argumentsAsAnonymousType) where T : IView
        {
            return _container.Resolve<T>(argumentsAsAnonymousType);
        }
    }
}
