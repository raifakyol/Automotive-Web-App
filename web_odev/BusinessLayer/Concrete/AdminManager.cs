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
    public class AdminManager : IAdminService
    {
        IAdminDal _admindal;
        public AdminManager(IAdminDal admindal)
        {
            _admindal = admindal;
        }

        public void AdminAdd(Admin admin)
        {
            _admindal.AddAdmin(admin);
        }

        public void AdminDelete(Admin admin)
        {
            _admindal.DeleteAdmin(admin);
        }

        public void AdminUpdate(Admin admin)
        {
            _admindal.UpdateAdmin(admin);
        }

        public Admin GetById(int id)
        {
            return _admindal.GetById(id);
        }

        public List<Admin> GetList()
        {
            return _admindal.ListAllAdmin();
        }
    }
}
