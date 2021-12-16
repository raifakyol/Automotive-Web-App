using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOpsiyonlarService
    {
        void OpsiyonlarAdd(Opsiyonlar arac);
        void OpsiyonlarDelete(Opsiyonlar arac);
        void OpsiyonlarUpdate(Opsiyonlar arac);
        List<Opsiyonlar> GetList();
        Opsiyonlar GetById(int id);
    }
}
