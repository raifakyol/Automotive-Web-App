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
    public class AracManager : IAracService
    {
        IAracDal _aracDal;

        public AracManager(IAracDal aracDal)
        {
            _aracDal = aracDal;
        }
        public void AracAdd(Arac arac)
        {
            _aracDal.AddArac(arac);
        }

        public void AracDelete(Arac arac)
        {
            _aracDal.DeleteArac(arac);
        }

        public void AracUpdate(Arac arac)
        {
            _aracDal.UpdateArac(arac);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public Arac GetById(int id)
        {
            return _aracDal.GetById(id);
        }

        public List<Arac> GetList()
        {
            return _aracDal.ListAllArac();
        }

    }
}
