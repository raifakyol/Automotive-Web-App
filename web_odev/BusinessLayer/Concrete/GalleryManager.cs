using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GalleryManager : IGalleryService
    {
        IGalleryDal _galleryDal;
        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }
        public void GalleryAdd(Gallery arac)
        {
            throw new NotImplementedException();
        }

        public void GalleryDelete(Gallery arac)
        {
            throw new NotImplementedException();
        }

        public void GalleryUpdate(Gallery arac)
        {
            throw new NotImplementedException();
        }

        public Gallery GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Gallery> GetList()
        {
            return _galleryDal.ListAllGallery();
        }
    }
}
