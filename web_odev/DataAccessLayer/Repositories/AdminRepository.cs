using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AdminRepository : IAdminDal
    {
        public void AddAdmin(Admin admin)
        {
            using var c = new Context();
            c.Add(admin);
            c.SaveChanges();
        }

        public void DeleteAdmin(Admin admin)
        {
            using var c = new Context();
            c.Remove(admin);
            c.SaveChanges();
        }

        public Admin GetById(int id)
        {
            using var c = new Context();
            return c.Admins.Find(id);
        }

        public List<Admin> ListAllAdmin()
        {
            using var c = new Context();
            return c.Admins.ToList();
        }

        public void UpdateAdmin(Admin admin)
        {
            using var c = new Context();
            c.Update(admin);
            c.SaveChanges();
        }
    }
}
