using Ninject.Modules;
using Ninject;
using DAL;

public class Bindings : NinjectModule
{
    public override void Load()
    {
        Bind<IUOW>().To<UOWTEST>();
    }
}