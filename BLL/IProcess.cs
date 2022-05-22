using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface IProcess
    {
        String GetSeasonDishes();

        String GetTypeDishes();

        String Exists(String name);

        String Order(String name, int orderid);

        String CreateOrder(String order);

        String RemoveOrder(String order);
    }
}
