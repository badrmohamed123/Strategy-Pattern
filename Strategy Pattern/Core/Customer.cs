using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Core
{
    internal class Customer
    {
        public int id { get; set; }
        public string name { get; set; }

        public CustomerCategory Category { get; set; }
    }
}
