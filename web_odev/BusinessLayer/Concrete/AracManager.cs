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
            throw new NotImplementedException();
        }

        public void AracDelete(Arac arac)
        {
            throw new NotImplementedException();
        }

        public void AracUpdate(Arac arac)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public Arac GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Arac> GetList()
        {
            return _aracDal.ListAllArac();
        }

    }
}
