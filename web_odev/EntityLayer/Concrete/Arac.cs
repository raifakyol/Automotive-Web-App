using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Arac
    {
        [Key]
        public int AracID { get; set; }

        public int Marka_id { get; set; }
        public int Model_id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Donanim { get; set; }
        public string Motor_hacmi { get; set; }
        public string Yakit_tipi { get; set; }
        public string Vites_tipi { get; set; }
        public int AracBg { get; set; }
        public string Fiyat { get; set; }

        public List<Opsiyonlar> Options { get; set; }
    }
}
