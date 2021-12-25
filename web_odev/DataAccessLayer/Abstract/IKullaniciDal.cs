using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IKullaniciDal
    {
        List<Kullanici> ListAllKullanici();
        void AddKullanici(Kullanici kullanici);
        void DeleteKullanici(Kullanici kullanici);
        void UpdateKullanici(Kullanici kullanici);
        Kullanici GetById(int id);
    }
}
