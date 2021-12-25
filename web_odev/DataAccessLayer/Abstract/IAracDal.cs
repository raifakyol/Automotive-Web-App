using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAracDal 
    {
        List<Arac> ListAllArac();
        void AddArac(Arac arac);
        void DeleteArac(Arac arac);
        void UpdateArac(Arac arac);
        Arac GetById(int id);
    }
}
