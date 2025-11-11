using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikestore.Models
{
    public class CurrentOrder
    {

        public int OrderFk { get; set; }

        public int ProductFk { get; set; }

        public int Quantity { get; set; }

        public decimal? ListPrice { get; set; }

        public decimal? Discount { get; set; }

    }
}
