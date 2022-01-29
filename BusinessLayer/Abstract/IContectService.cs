using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContectService
    {
        List<Contect> GetAll();
        void ContectAdd(Contect contect);
        void ContectUpdate(Contect contect);
        void ContectRemove(Contect contect);
        Contect GetById(int ID);
    }
}
