using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    // реализует Waiter
    public class Waiter : Employee
    {
        public override decimal GetPrice()
        {
            return Rate * 8;
        }
    }
}
