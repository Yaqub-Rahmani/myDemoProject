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
    public class CompanyManager: ICompanyService
    {
        ICompanyDal _iCompanyDal;

        public CompanyManager(ICompanyDal iCompanyDal)
        {
            _iCompanyDal = iCompanyDal;
        }

        public void CompanyAdd(Company company)
        {
            _iCompanyDal.Insert(company);
        }

        public void CompanyRemove(Company company)
        {
            _iCompanyDal.Delete(company);
        }

        public void CompanyUpdate(Company company)
        {
            _iCompanyDal.Update(company);
        }

        public List<Company> GetAll()
        {
            return _iCompanyDal.List();
        }

        public Company GetById(int ID)
        {
            return _iCompanyDal.Get(x => x.companyID == ID);
        }
    }
}
