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
    public class KullaniciRepository : IKullaniciDal
    {
        public void AddKullanici(Kullanici kullanici)
        {
            using var c = new Context();
            c.Add(kullanici);
            c.SaveChanges();
        }

        public void DeleteKullanici(Kullanici kullanici)
        {
            using var c = new Context();
            c.Remove(kullanici);
            c.SaveChanges();
        }

        public Kullanici GetById(int id)
        {
            using var c = new Context();
            return c.Users.Find(id);
        }

        public List<Kullanici> ListAllKullanici()
        {
            using var c = new Context();
            return c.Users.ToList();
        }

        public void UpdateKullanici(Kullanici kullanici)
        {
            using var c = new Context();
            c.Update(kullanici);
            c.SaveChanges();
        }


    }
}
