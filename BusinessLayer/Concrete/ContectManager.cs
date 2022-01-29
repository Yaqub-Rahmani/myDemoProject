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
    public class ContectManager: IContectService
    {
        IContectDal _iContectDal;

        public ContectManager(IContectDal iContectDal)
        {
            _iContectDal = iContectDal;
        }

        public void ContectAdd(Contect contect)
        {
            _iContectDal.Insert(contect);
        }

        public void ContectRemove(Contect contect)
        {
            _iContectDal.Delete(contect);
        }

        public void ContectUpdate(Contect contect)
        {
            _iContectDal.Update(contect);
        }

        public List<Contect> GetAll()
        {
            return _iContectDal.List();
        }

        public Contect GetById(int ID)
        {
            return _iContectDal.Get(x => x.contectID == ID);
        }
    }
}
