using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssemblyServices.Model.catalog
{
    public abstract class Catalog
    {
        public List<Catalog> Catalogs { get; }
        public CatalogTypes CatalogType { get; }
    }
}
