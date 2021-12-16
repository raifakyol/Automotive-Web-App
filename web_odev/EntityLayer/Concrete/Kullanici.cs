using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }

       
        public string Kullanici_AdSoyad { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Plaka { get; set; }
        public string Kullanici_Tarih { get; set; }
        public string Telefon { get; set; }

        public int AracID { get; set; }
        public Arac Arac { get; set; }
    }
}
