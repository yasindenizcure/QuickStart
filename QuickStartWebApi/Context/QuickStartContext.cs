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
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
    }
}
