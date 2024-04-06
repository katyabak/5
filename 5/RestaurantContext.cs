using Microsoft.EntityFrameworkCore;

namespace _5
{
    // контекст БД для работы с таблицей сотрудников
    public class RestaurantContext : DbContext
    {
        //public DbSet<Employee> Employees { get; set; }
        public DbSet<KitchenStaff> KitchenStaff { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<JuniorManager> JuniorManagers { get; set; }
        public RestaurantContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ВУЗ\4 семестр\Проектировние\labs\4\Rabotniki.mdf;Integrated Security=True;");
        }
    }
}
