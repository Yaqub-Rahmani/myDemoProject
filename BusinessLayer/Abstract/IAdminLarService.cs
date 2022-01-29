using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminLarService
    {
        List<AdminLar> GetAll();
        void AdminLarAdd(AdminLar adminLar);
        void AdminLarUpdate(AdminLar adminLar);
        void AdminLarRemove(AdminLar adminLar);
        AdminLar GetById(int ID);
        AdminLar GetByUserNameForLogin(AdminLar adminLar);
        AdminLar GetByUserName(String admin);
    }
}
