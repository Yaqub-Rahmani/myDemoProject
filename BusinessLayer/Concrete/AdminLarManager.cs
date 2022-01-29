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
    public class AdminLarManager: IAdminLarService
    {
        IAdminLarDal _iAdminLarDal;

        public AdminLarManager(IAdminLarDal iAdminLarDal)
        {
            _iAdminLarDal = iAdminLarDal;
        }

        public void AdminLarAdd(AdminLar adminLar)
        {
            _iAdminLarDal.Insert(adminLar);
        }

        public void AdminLarRemove(AdminLar adminLar)
        {
            _iAdminLarDal.Delete(adminLar);
        }

        public void AdminLarUpdate(AdminLar adminLar)
        {
            _iAdminLarDal.Update(adminLar);
        }

        public List<AdminLar> GetAll()
        {
            return _iAdminLarDal.List();
        }

        public AdminLar GetById(int ID)
        {
            return _iAdminLarDal.Get(x => x.AdminID == ID);
        }

        public AdminLar GetByUserName(string admin)
        {
            return _iAdminLarDal.Get(x => x.AdminUserName.Equals(admin));
        }

        public AdminLar GetByUserNameForLogin(AdminLar adminLar)
        {
            return _iAdminLarDal.Get(x => x.AdminUserName.Equals(adminLar.AdminUserName) && x.AdminPassword.Equals(adminLar.AdminPassword) && x.AdminAct.Equals(true));
        }
    }
}
