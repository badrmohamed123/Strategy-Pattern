using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Core.DiscountStrategy
{
    internal interface ICustomerDiscountStrategy
    {
         double CalculateDiscount(double totalprice);
    }
}
