using PCAssemblyServices.Model.catalog.view;
using System.Collections.Generic;

namespace PCAssemblyServices.Model.catalog
{
    public class ProcessorCatalog : Catalog
    {
        public List<ProcessorView> Products { get; }
    }
}
