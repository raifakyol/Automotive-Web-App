using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Opsiyonlar
    {
        [Key]
        public int Opsiyon_ID { get; set; }
        
        public int Marka_id { get; set; }
        public int Model_id { get; set; }
        public string Opsiyon_Adi { get; set; }
        public string Opsiyon_Fiyati { get; set; }

        public int AracID { get; set; }
        public Arac Arac { get; set; }
    }
}
