using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace foy_5.Model
{
    public class OgrenciDers
    {
        public int ogrenciDersID {  get; set; }
        public int ogrenciID { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }

        public int dersID { get; set; }
        public virtual Ders Ders { get; set; }

        public string yil { get; set; }
        public string yariyil { get; set; }

        public int? vize { get; set; }
        public int? final { get; set; }
    }
}
