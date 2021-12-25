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
    public class OpsiyonlarManager : IOpsiyonlarService
    {
        IOpsiyonlarDal _opsiyonlarDal;
        public OpsiyonlarManager(IOpsiyonlarDal opsiyonlarDal)
        {
            _opsiyonlarDal = opsiyonlarDal;
        }
        public Opsiyonlar GetById(int id)
        {
            return _opsiyonlarDal.GetById(id);
        }

        public List<Opsiyonlar> GetList()
        {
            return _opsiyonlarDal.ListAllOpsiyonlar();
        }

        public void OpsiyonlarAdd(Opsiyonlar arac)
        {
            _opsiyonlarDal.AddOpsiyonlar(arac);
        }

        public void OpsiyonlarDelete(Opsiyonlar arac)
        {
            _opsiyonlarDal.DeleteOpsiyonlar(arac);
        }

        public void OpsiyonlarUpdate(Opsiyonlar arac)
        {
            _opsiyonlarDal.UpdateOpsiyonlar(arac);
        }


    }
}
