using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlHelper
{
    class Mapper<T> : IMapper<T>
    {
        public List<T> AllItems()
        {
            List<T> vs = new List<T>();
            return vs;
        }
    }
}
