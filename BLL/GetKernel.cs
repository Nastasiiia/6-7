using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class GetKernel
    {
        public static IProcess Get()
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(System.Reflection.Assembly.GetExecutingAssembly());
            return kernel.Get<IProcess>();
        }
    }
}
