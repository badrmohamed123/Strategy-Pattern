using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Core
{
    internal class invoice
    {
        public Customer Customer{ get; set; }
        public IEnumerable<invoiceline> Lines { get; set; }
        public double Totalprice => Lines.Sum(x => x.Quantity * x.UnitPrice);
        public double DiscountPercentage { get; set; }
        
        public double Netprice => Totalprice - (Totalprice * DiscountPercentage);
    }
}
