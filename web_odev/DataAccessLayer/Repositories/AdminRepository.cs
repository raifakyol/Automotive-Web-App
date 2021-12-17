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
    public class AdminRepository : IAdminDal
    {
        public void Insert(Admin admin)
        {
            using var c = new Context();
            c.Add(admin);
            c.SaveChanges();
        }
    }
}
