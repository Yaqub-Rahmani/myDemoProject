using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWeOfferService
    {
        List<WeOffer> GetAll();
        void WeOfferAdd(WeOffer weOffer);
        void WeOfferUpdate(WeOffer weOffer);
        WeOffer GetById(int ID);
    }
}
