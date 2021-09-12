using OtoServisSatis.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OtoServisSatis.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Servis> Servisler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>
        {
            protected override void Seed(DatabaseContext context)
            {
                //if (!context.Kullanicilar.Any())
                //{
                //    context.Kullanicilar.Add(new Kullanici()
                //    {
                //        Adi = "Admin",
                //        AktifMi = true,
                //        EklenmeTarihi = DateTime.Now,
                //        Email = "admin@otoservissatis.tc",
                //        KullaniciAdi = "admin",
                //        Sifre = "123456"
                //    });
                //    context.SaveChanges();
                //}
                base.Seed(context);
            }
        }

        public DatabaseContext() : base("name=DatabaseContext")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

    }
}

/*
 * EF de Migrationu aktif etme
 * 1-App.config dosyalarına(DAL katmanı ve WindowsApp katmanı) connection stringi oluşturuyoruz
 * 2-PMC konsolunu view menüsünden aktif ettik
 * 3-PMC konsolunda aktif proje olarak sağ üst menüden projeadı.DAL katmanını seçip enable-migrations yazıp enter a bastık
 * 4-Migration klasörü Dal katmanına geldikten sonra PMC konsolunda DAL projesine add-migration migrationismi komutu ile enter a basarak bir migration oluşturduk
 * 5-ismini verip oluşturduğumuz migration, migrations klasörüne eklendikten sonra PMC konsoluna update-database diyerek veritabanımızın kurulmasını sağladık.
 */