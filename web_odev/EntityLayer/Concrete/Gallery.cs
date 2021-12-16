using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Gallery
    {
        [Key]
        public int GalleryID { get; set; }
        public string GalleryAd { get; set; }
        public string GalleryResim { get; set; }

        public int AracID { get; set; }
        public Arac Arac { get; set; }
    }
}
