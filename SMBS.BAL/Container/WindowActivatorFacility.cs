using Castle.MicroKernel.Facilities;
using SMBS.BAL.Mvvm;

namespace SMBS.BAL.Container
{
    public class WindowActivatorFacility: AbstractFacility
    {
        protected override void Init()
        {
            Kernel.ComponentModelCreated += OnComponentModelCreated;
        }

        protected override void Dispose()
        {
            Kernel.ComponentModelCreated -= OnComponentModelCreated;
            base.Dispose();
        }

        private void OnComponentModelCreated(Castle.Core.ComponentModel model)
        {
            var isView = typeof(IView).IsAssignableFrom(model.Implementation);
            if (!isView) return;

            if (model.CustomComponentActivator == null)
                model.CustomComponentActivator = typeof(WindowActivator);
        }
    }
}
