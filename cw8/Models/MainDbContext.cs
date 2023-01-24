using Microsoft.EntityFrameworkCore;
using System.Data;

namespace cw8.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
        { }
        public MainDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Studia> Studia { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=cw7;trustServerCertificate=true;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var a = new Student { IdStudent = 1, Imie = "Jan", Nazwisko = "Burak", NrIndeksu = "1234", RokStudiow = 1 };
            var b = new Student { IdStudent = 2, Imie = "Karol", Nazwisko = "Rzepa", NrIndeksu = "55555", RokStudiow = 2 };
            modelBuilder.Entity<Student>(s =>
            {
                s.HasData(a,
                        b
                    );
            });
            modelBuilder.Entity<Studia>(s =>
            {
                s.HasData(new Studia { IdStudia = 1, Nazwa = "Dlugie studia", Tryb="stacjonarne",IdStudent=1}
                    );
            });
        }
    }
}
