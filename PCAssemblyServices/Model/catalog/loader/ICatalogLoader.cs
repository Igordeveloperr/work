using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssemblyServices.Model.catalog.loader
{
    public interface ICatalogLoader
    {
        void LoadCatalog(CatalogTypes catalogType, List<Catalog> catalog);
    }
}
