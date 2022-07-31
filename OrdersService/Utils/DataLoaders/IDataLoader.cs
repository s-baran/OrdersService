using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Utils.DataLoaders
{
    public interface IDataLoader<T>
    {
        T Load();
    }
}
