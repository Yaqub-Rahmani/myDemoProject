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
    public class WhatWeDoManager: IWhatWeDoService
    {
        IWhatWeDoDal _iWhatWeDoDal;

        public WhatWeDoManager(IWhatWeDoDal iWhatWeDoDal)
        {
            _iWhatWeDoDal = iWhatWeDoDal;
        }

        public List<WhatWeDo> GetAll()
        {
            return _iWhatWeDoDal.List();
        }

        public WhatWeDo GetById(int ID)
        {
            return _iWhatWeDoDal.Get(x => x.whatwedoID == ID);
        }

        public void WhatWeDoAdd(WhatWeDo whatWeDo)
        {
            _iWhatWeDoDal.Insert(whatWeDo);
        }

        public void WhatWeDoUpdate(WhatWeDo whatWeDo)
        {
            _iWhatWeDoDal.Update(whatWeDo);
        }
    }
}
