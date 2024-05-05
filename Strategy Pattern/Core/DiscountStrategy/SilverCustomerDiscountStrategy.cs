using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Core.DiscountStrategy
{
    internal class SilverCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalprice)
        { 
        return totalprice >= 10000 ? 0.05 : 0 ; 
        }
    }
}
