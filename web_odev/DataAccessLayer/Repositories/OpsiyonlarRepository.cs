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
    public class OpsiyonlarRepository : IOpsiyonlarDal
    {
        public void AddOpsiyonlar(Opsiyonlar opsiyonlar)
        {
            using var c = new Context();
            c.Add(opsiyonlar);
            c.SaveChanges();
        }

        public void DeleteOpsiyonlar(Opsiyonlar opsiyonlar)
        {
            using var c = new Context();
            c.Remove(opsiyonlar);
            c.SaveChanges();
        }

        public Opsiyonlar GetById(int id)
        {
            using var c = new Context();
            return c.Options.Find(id);
        }

        public List<Opsiyonlar> ListAllOpsiyonlar()
        {
            using var c = new Context();
            return c.Options.ToList();
        }

        public void UpdateOpsiyonlar(Opsiyonlar opsiyonlar)
        {
            using var c = new Context();
            c.Update(opsiyonlar);
            c.SaveChanges();
        }
    }
}
