using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    // модель с 3 лр
    public abstract class Employee
    {
        [Key] // первичный ключ
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Rate { get; set; }

        // абстрактные методы, которые будут реализованы в наследниках
        public abstract decimal GetPrice();
    }
}
