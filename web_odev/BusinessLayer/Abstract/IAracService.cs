using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAracService
    {
        void AracAdd(Arac arac);
        void AracDelete(Arac arac);
        void AracUpdate(Arac arac);
        List<Arac> GetList();
        Arac GetById(int id);
    }
}
