using System.Data.Entity;

namespace ClassWork16.Models
{
    public class LanguageContext : DbContext
    {
        public DbSet<Language> Languages { get; set; }
    }
}