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
    public class EmployeeUserManager : IEmployeeUserService
    {
        IEmployeeUserDal _iEmployeeUserDal;

        public EmployeeUserManager(IEmployeeUserDal iEmployeeUserDal)
        {
            _iEmployeeUserDal = iEmployeeUserDal;
        }

        public void EmployeeUserAdd(EmployeeUser employeeUser)
        {
            _iEmployeeUserDal.Insert(employeeUser);
        }

        public void EmployeeUserRemove(EmployeeUser employeeUser)
        {
            _iEmployeeUserDal.Delete(employeeUser);
        }

        public void EmployeeUserUpdate(EmployeeUser employeeUser)
        {
            _iEmployeeUserDal.Update(employeeUser);
        }

        public List<EmployeeUser> GetAll()
        {
            return _iEmployeeUserDal.List();
        }

        public EmployeeUser GetById(int ID)
        {
            return _iEmployeeUserDal.Get(x => x.employeeID == ID);
        }
    }
}
