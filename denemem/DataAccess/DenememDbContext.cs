using denemem.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemem.DataAccess
{
    public class DenememDbContext:DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        public DenememDbContext()
        {
            Database.SetInitializer(new UrunlerDbCreator());
        }
        public class UrunlerDbCreator:CreateDatabaseIfNotExists<DenememDbContext>
        {
            public override void InitializeDatabase(DenememDbContext context)
            {
                base.InitializeDatabase(context);
            }
            protected override void Seed(DenememDbContext context)
            {
                for (int i = 0; i < 7; i++)
                {
                    Kategori kat = new Kategori();
                    kat.KategoriAdi = "DENEME" + i;
                    context.Kategoriler.Add(kat);   
                    
                }
                context.SaveChanges();
            }

        }
    }
}
