using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace foy_5.Model
{
    public class Foy5Context : DbContext
    {
        public Foy5Context() : base("name=foy5Entities") { }

        public DbSet<Fakulte> Fakulte { get; set; }
        public DbSet<Bolum> Bolum { get; set; }
        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<OgrenciDers> OgrenciDers { get; set; }
    }
}
