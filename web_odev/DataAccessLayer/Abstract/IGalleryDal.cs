using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGalleryDal
    {
        List<Gallery> ListAllGallery();
        void AddGallery(Gallery gallery);
        void DeleteGallery(Gallery gallery);
        void UpdateGallery(Gallery gallery);
        Gallery GetById(int id);
    }
}
