using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    // реализует JuniorManager
    public class JuniorManager : Employee
    {
        public int Bonus { get; set; }
        public int YearsWorked { get; set; }
        public override decimal GetPrice()
        {
            return Rate + (Bonus * YearsWorked);
        }
    }
}
