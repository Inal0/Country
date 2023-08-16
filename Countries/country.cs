using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    class Country
    {
        internal string Name;

        public List<City> City { get; internal set; }
    }
}
