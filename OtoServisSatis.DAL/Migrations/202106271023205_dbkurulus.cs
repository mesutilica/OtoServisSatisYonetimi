namespace OtoServisSatis.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbkurulus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arac",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarkaId = c.Int(nullable: false),
                        Renk = c.String(),
                        Fiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Modeli = c.String(),
                        KasaTipi = c.String(),
                        ModelYili = c.Int(nullable: false),
                        SatistaMi = c.Boolean(nullable: false),
                        Notlar = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marka", t => t.MarkaId, cascadeDelete: true)
                .Index(t => t.MarkaId);
            
            CreateTable(
                "dbo.Marka",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        Email = c.String(),
                        Telefon = c.String(),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        RolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rol", t => t.RolId, cascadeDelete: true)
                .Index(t => t.RolId);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AracId = c.Int(nullable: false),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        TcNo = c.String(),
                        Email = c.String(),
                        Adres = c.String(),
                        Telefon = c.String(),
                        Notlar = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Arac", t => t.AracId, cascadeDelete: true)
                .Index(t => t.AracId);
            
            CreateTable(
                "dbo.Satis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AracId = c.Int(nullable: false),
                        MusteriId = c.Int(nullable: false),
                        SatisFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SatisTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Arac", t => t.AracId, cascadeDelete: false)
                .ForeignKey("dbo.Musteri", t => t.MusteriId, cascadeDelete: false)
                .Index(t => t.AracId)
                .Index(t => t.MusteriId);
            
            CreateTable(
                "dbo.Servis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiseGelisTarihi = c.DateTime(nullable: false),
                        AracSorunu = c.String(),
                        ServisUcreti = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServistenCikisTarihi = c.DateTime(nullable: false),
                        YapilanIslemler = c.String(),
                        GarantiKapsamindaMi = c.Boolean(nullable: false),
                        AracPlaka = c.String(),
                        Marka = c.String(),
                        Model = c.String(),
                        KasaTipi = c.String(),
                        SaseNo = c.String(),
                        Notlar = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Satis", "MusteriId", "dbo.Musteri");
            DropForeignKey("dbo.Satis", "AracId", "dbo.Arac");
            DropForeignKey("dbo.Musteri", "AracId", "dbo.Arac");
            DropForeignKey("dbo.Kullanici", "RolId", "dbo.Rol");
            DropForeignKey("dbo.Arac", "MarkaId", "dbo.Marka");
            DropIndex("dbo.Satis", new[] { "MusteriId" });
            DropIndex("dbo.Satis", new[] { "AracId" });
            DropIndex("dbo.Musteri", new[] { "AracId" });
            DropIndex("dbo.Kullanici", new[] { "RolId" });
            DropIndex("dbo.Arac", new[] { "MarkaId" });
            DropTable("dbo.Servis");
            DropTable("dbo.Satis");
            DropTable("dbo.Musteri");
            DropTable("dbo.Rol");
            DropTable("dbo.Kullanici");
            DropTable("dbo.Marka");
            DropTable("dbo.Arac");
        }
    }
}
