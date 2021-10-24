using ArquiteturaDemo.Domain.Interfaces;
using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using Ninject;


namespace ArquiteturaDemo.Infra.IoC
{
    public  class IoC
    {
        public static void Init()
        {
            var kernel = new StandardKernel(new IoCModule());

            //kernel.Get<IEstadoRepository>();
            //kernel.Get<ICidadeRepository>();


            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(kernel));
        }
    }
}
