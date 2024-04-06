using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using _5;
class Program
{
    static void Main()
    {
        using (var context = new RestaurantContext())
        {
            // добавление сотрудников в БД
            AddEmployeesToDatabase(context);
            // извлечение данных о сотрудниках из БД и расчет ЗП
            CalculateAndDisplaySalaries(context);
        }
    }

    static void AddEmployeesToDatabase(RestaurantContext context)
    {
        // добавляем всех сотрудников
        var employees = new Employee[]
        {
            new KitchenStaff { Name = "Иван", HireDate = DateTime.Now, Rate = 10m },
            new KitchenStaff { Name = "Евгения", HireDate = DateTime.Now, Rate = 12m },
            new Waiter { Name = "Алексей", HireDate = DateTime.Now, Rate = 8m },
            new Waiter { Name = "Елена", HireDate = DateTime.Now, Rate = 9m },
            new Manager { Name = "Дмитрий", HireDate = DateTime.Now, Rate = 20m, Bonus = 500, YearsWorked = 6 },
            new JuniorManager { Name = "Ольга", HireDate = DateTime.Now, Rate = 18m, Bonus = 300, YearsWorked = 5 }
        };
        //context.AddRange(employees);
        context.Managers.Add(new Manager { Name = "Дмитрий", HireDate = DateTime.Now, Rate = 20m, Bonus = 500, YearsWorked = 6 });
        context.SaveChanges();
    }
    static void CalculateAndDisplaySalaries(RestaurantContext context) // расчет ЗП + вывод
    {
        var employees = context.Employees.ToList();
        foreach (var employee in employees)
        {
            decimal salary = employee.GetPrice();
            Console.WriteLine($"Заработная плата: {salary}");
        }
    }
}


