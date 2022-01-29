using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICatagoryService
    {
        List<Catagory> GetAll();
        void CatagoryAdd(Catagory catagory);
        void CatagoryUpdate(Catagory catagory);
        void CatagoryRemove(Catagory catagory);
        Catagory GetById(int ID);
    }
}
