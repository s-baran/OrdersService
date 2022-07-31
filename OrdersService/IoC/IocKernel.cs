using Ninject;
using Ninject.Modules;

namespace OrdersService.IoC
{
    public static class IocKernel
    {
        private static StandardKernel kernel;
        public static T Get<T>() => kernel.Get<T>();
        public static void Initialize(params INinjectModule[] modules)
        {
            if (kernel == null)
            {
                kernel = new StandardKernel(modules);
            }
        }
    }
}
