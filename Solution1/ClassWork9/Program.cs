using System;
using System.Data.Entity;

namespace ClassWork9
{
    public class Program
    {
        public static void Main()
        {
            using (var db = new ClassWork9DbContext())
            {
                foreach (var c in db.Set<EmployeType>())
                {
                    Console.WriteLine($"{c.Id} {c.Name}");
                }

                //db.SaveChanges();
            }
        }
    }
    public class ClassWork9DbContext : DbContext
    {
        public ClassWork9DbContext() : base("name=ClassWork9")
        {

        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employees>();
        //}

        public DbSet<Employe> Employees { get; set; }
    }

    public class Employe
    {
        public int CityId { get; set; }

        public string Name { get; set; }
    }

    public class EmployeType
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

}
