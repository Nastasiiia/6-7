using Ninject.Modules;
using Ninject;
using BLL;

public class Bindings : NinjectModule
{
    public override void Load()
    {
        Bind<IProcess>().To<Process>();
    }
}