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
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullanicidal;
        public KullaniciManager(IKullaniciDal kullanicidal)
        {
            _kullanicidal = kullanicidal;
        }
        public Kullanici GetById(int id)
        {
            return _kullanicidal.GetById(id);
        }

        public List<Kullanici> GetList()
        {
            return _kullanicidal.ListAllKullanici();
        }

        public void KullaniciAdd(Kullanici kullanici)
        {
            _kullanicidal.AddKullanici(kullanici);
        }

        public void KullaniciDelete(Kullanici kullanici)
        {
            _kullanicidal.DeleteKullanici(kullanici);
        }

        public void KullaniciUpdate(Kullanici kullanici)
        {
            _kullanicidal.UpdateKullanici(kullanici);
        }
    }
}
