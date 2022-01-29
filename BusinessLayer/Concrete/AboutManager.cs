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
    public class AboutManager: IAboutService
    {
        IAboutDal _iAboutDal;

        public AboutManager(IAboutDal iAboutDal)
        {
            _iAboutDal = iAboutDal;
        }

        public void AboutAdd(About about)
        {
            _iAboutDal.Insert(about);
        }

        public void AboutRemove(About about)
        {
            _iAboutDal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            _iAboutDal.Update(about);
        }

        public List<About> GetAll()
        {
            return _iAboutDal.List();
        }

        public About GetById(int ID)
        {
            return _iAboutDal.Get(x => x.aboutID == ID);
        }
    }
}
