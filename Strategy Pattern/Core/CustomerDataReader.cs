using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Core
{
     class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
            {
               new Customer()
               {
                   id = 1,
                   name = "Badr",
                   Category = CustomerCategory.Gold
               },
               new Customer()
               {
                   id=2,
                   name = "Mohamed",
                   Category = CustomerCategory.Silver
               }

            };
        }
    }
}
