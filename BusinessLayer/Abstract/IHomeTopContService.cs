using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHomeTopContService
    {
        List<HomeTopCont> GetAll();
        void HomeTopContAdd(HomeTopCont homeTopCont);
        void HomeTopContUpdate(HomeTopCont homeTopCont);
        HomeTopCont GetById(int ID);
    }
}
