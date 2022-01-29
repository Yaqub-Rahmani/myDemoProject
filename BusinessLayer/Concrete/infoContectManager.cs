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
    public class infoContectManager: IinfoContectService
    {
        IinfoContectDal _iinfoContectDal;

        public infoContectManager(IinfoContectDal iinfoContectDal)
        {
            _iinfoContectDal = iinfoContectDal;
        }

        public List<infoContect> GetAll()
        {
            return _iinfoContectDal.List();
        }

        public infoContect GetById(int ID)
        {
            return _iinfoContectDal.Get(x => x.mcontectID == ID);
        }

        public void infoContectAdd(infoContect infoContect)
        {
            _iinfoContectDal.Insert(infoContect);
        }

        public void infoContectUpdate(infoContect infoContect)
        {
            _iinfoContectDal.Update(infoContect);
        }
    }
}
