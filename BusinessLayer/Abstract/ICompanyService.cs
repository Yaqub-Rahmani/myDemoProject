using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICompanyService
    {
        List<Company> GetAll();
        void CompanyAdd(Company company);
        void CompanyUpdate(Company company);
        void CompanyRemove(Company company);
        Company GetById(int ID);
    }
}
