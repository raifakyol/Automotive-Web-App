using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GalleryRepository : IGalleryDal
    {
        public void AddGallery(Gallery gallery)
        {
            using var c = new Context();
            c.Add(gallery);
            c.SaveChanges();
        }

        public void DeleteGallery(Gallery gallery)
        {
            using var c = new Context();
            c.Remove(gallery);
            c.SaveChanges();
        }

        public Gallery GetById(int id)
        {
            using var c = new Context();
            return c.Gallerys.Find(id);
        }

        public List<Gallery> ListAllGallery()
        {
            using var c = new Context();
            return c.Gallerys.ToList();
        }

        public void UpdateGallery(Gallery gallery)
        {
            using var c = new Context();
            c.Update(gallery);
            c.SaveChanges();
        }
    }
}
