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
    public class HomeTopContManager: IHomeTopContService
    {
        IHomeTopContDal _iHomeTopContDal;

        public HomeTopContManager(IHomeTopContDal iHomeTopContDal)
        {
            _iHomeTopContDal = iHomeTopContDal;
        }

        public List<HomeTopCont> GetAll()
        {
            return _iHomeTopContDal.List();
        }

        public HomeTopCont GetById(int ID)
        {
            return _iHomeTopContDal.Get(x => x.homtopcontID == ID);
        }

        public void HomeTopContAdd(HomeTopCont homeTopCont)
        {
            _iHomeTopContDal.Insert(homeTopCont);
        }

        public void HomeTopContUpdate(HomeTopCont homeTopCont)
        {
            _iHomeTopContDal.Update(homeTopCont);
        }
    }
}
