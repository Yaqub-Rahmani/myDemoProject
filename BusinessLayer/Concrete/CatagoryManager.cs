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
    public class CatagoryManager : ICatagoryService
    {
        ICatagoryDal _iCatagoryDal;

        public CatagoryManager(ICatagoryDal iCatagoryDal)
        {
            _iCatagoryDal = iCatagoryDal;
        }

        public void CatagoryAdd(Catagory catagory)
        {
            _iCatagoryDal.Insert(catagory);
        }

        public void CatagoryRemove(Catagory catagory)
        {
            _iCatagoryDal.Delete(catagory);
        }

        public void CatagoryUpdate(Catagory catagory)
        {
            _iCatagoryDal.Update(catagory);
        }

        public List<Catagory> GetAll()
        {
            return _iCatagoryDal.List();
        }

        public Catagory GetById(int ID)
        {
            return _iCatagoryDal.Get(x => x.catagoryID == ID);
        }
    }
}
