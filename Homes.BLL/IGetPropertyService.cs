using Homes.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homes.BLL
{
    public interface IGetPropertyService
    {
        IEnumerable<Property> GetProperties();
    }
}
