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
    public class WeOfferManager: IWeOfferService
    {
        IWeOfferDal _iWeOfferDal;

        public WeOfferManager(IWeOfferDal iWeOfferDal)
        {
            _iWeOfferDal = iWeOfferDal;
        }

        public List<WeOffer> GetAll()
        {
            return _iWeOfferDal.List();
        }

        public WeOffer GetById(int ID)
        {
            return _iWeOfferDal.Get(x => x.whatweofferID == ID);
        }

        public void WeOfferAdd(WeOffer weOffer)
        {
            _iWeOfferDal.Insert(weOffer);
        }

        public void WeOfferUpdate(WeOffer weOffer)
        {
            _iWeOfferDal.Update(weOffer);
        }
    }
}
