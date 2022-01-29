﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetAll();
        void AboutAdd(About about);
        void AboutUpdate(About about);
        void AboutRemove(About about);
        About GetById(int ID);
    }
}
