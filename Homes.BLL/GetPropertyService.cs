using Homes.BLL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homes.BLL
{
    internal class GetPropertyService : IGetPropertyService
    {
        public IEnumerable<Property> GetProperties()
        {
            return Enumerable.Empty<Property>();
        }
    }
}
