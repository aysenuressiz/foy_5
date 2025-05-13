using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foy_5.Model
{
    public class Bolum
    {
        public int bolumID { get; set; }
        public string bolumAd { get; set; }

        public int FakulteID { get; set; }
        public virtual Fakulte Fakulte { get; set; }

    }
}
