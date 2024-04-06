using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    // реализует KitchenStaff
    public class KitchenStaff : Employee
    {
        public override decimal GetPrice()
        {
            return Rate * 8;
        }
    }
}
