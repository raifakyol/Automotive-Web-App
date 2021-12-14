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
    public class AracRepository : IAracDal
    {
        Context c = new Context();
        public void AddArac(Arac arac)
        {
            c.Add(arac);
            c.SaveChanges();
        }

        public void DeleteArac(Arac arac)
        {
            c.Remove(arac);
            c.SaveChanges();
        }

        public Arac GetById(int id)
        {
            return c.Cars.Find(id);
        }

        public List<Arac> ListAllArac()
        {
            return c.Cars.ToList();
        }

        public void UpdateArac(Arac arac)
        {
            c.Update(arac);
            c.SaveChanges();
        }
    }
}
