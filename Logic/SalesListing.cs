using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Logic
{
    public class SalesListing
    {
        public DateTime orderDate { get; set; }
        public string nombre { get; set; }
        public double precio_unitario { get; set; }
        public decimal cantidad { get; set; }
        public double descuento { get; set; }
        public double precio_total { get; set; }
    }
}
