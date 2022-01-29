using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEmployeeUserService
    {
        List<EmployeeUser> GetAll();
        void EmployeeUserAdd(EmployeeUser employeeUser);
        void EmployeeUserUpdate(EmployeeUser employeeUser);
        void EmployeeUserRemove(EmployeeUser employeeUser);
        EmployeeUser GetById(int ID);
    }
}
