using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    // реализует Manager
    public class Manager : Employee
    {
        public int Bonus { get; set; }
        public int YearsWorked { get; set; }
        public override decimal GetPrice()
        {
            return Rate + (Bonus * YearsWorked);
        }
    }
}
