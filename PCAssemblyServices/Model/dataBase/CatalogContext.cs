using PCAssemblyServices.Model.catalog;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssemblyServices.Model.dataBase
{
    public class CatalogContext : DataBaseContext
    {
        public DbSet<Catalog> Catalogs { get; set; }
        //public override bool Insert<T>(T catalog)
        //{
        //    Catalog cat = new ProcessorCatalog();
        //    if (catalog == null)
        //        return false;
        //    using (CatalogContext db = new CatalogContext())
        //    {
        //        var catalogType = catalog.GetType();
        //        db.Catalogs.Add();
        //    }
        //    return false;
        //}
    }
}
