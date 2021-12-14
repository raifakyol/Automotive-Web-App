using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IOpsiyonlarDal
    {
        List<Opsiyonlar> ListAllOpsiyonlar();
        void AddOpsiyonlar(Opsiyonlar opsiyonlar);
        void DeleteOpsiyonlar(Opsiyonlar opsiyonlar);
        void UpdateOpsiyonlar(Opsiyonlar opsiyonlar);
        Opsiyonlar GetById(int id);
    }
}
