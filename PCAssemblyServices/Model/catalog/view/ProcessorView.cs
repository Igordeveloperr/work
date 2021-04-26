using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssemblyServices.Model.catalog.view
{
    public class ProcessorView : ProductView
    {
        public string Manufactures { get; }
        public string Socket { get; }
        public int CoreAmount { get; }
        public double Frequency { get; }
    }
}
