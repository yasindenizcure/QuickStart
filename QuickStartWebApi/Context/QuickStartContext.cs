using Microsoft.EntityFrameworkCore;
using QuickStartWebApi.Entity;

namespace QuickStartWebApi.Context
{
    public class QuickStartContext: DbContext
    {
        // ORM nesne yönelimli programlama (OOP) dünyası ile ilişkisel veritabanı (SQL dünyası) arasındaki köprüdür.
        // SQL bağlantı adresimizi tutar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8TRT9BV\\MSSQLSERVER01; initial Catalog=QuickStartDB; integrated Security=true; TrustServerCertificate=true");   
        }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
