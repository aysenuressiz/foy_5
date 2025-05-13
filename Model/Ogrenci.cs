using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foy_5.Model
{
    public class Ogrenci
    {
        public int ogrenciID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }

        public int bolumID { get; set; }
        public virtual Bolum Bolum { get; set; }

    }
}
