using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IinfoContectService
    {
        List<infoContect> GetAll();
        void infoContectAdd(infoContect infoContect);
        void infoContectUpdate(infoContect infoContect);
        infoContect GetById(int ID);
    }
}
