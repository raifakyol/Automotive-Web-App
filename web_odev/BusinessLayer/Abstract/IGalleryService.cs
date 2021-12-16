using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGalleryService
    {
        void GalleryAdd(Gallery arac);
        void GalleryDelete(Gallery arac);
        void GalleryUpdate(Gallery arac);
        List<Gallery> GetList();
        Gallery GetById(int id);
    }
}
