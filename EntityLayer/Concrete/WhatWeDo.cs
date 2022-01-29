using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WhatWeDo
    {
        [Key]
        public int whatwedoID { get; set; }

        [StringLength(1000)]
        public string whatwedoText { get; set; }

        [StringLength(250)]
        public string whatwedoPhotoUrl { get; set; }

        public DateTime whetwedoDate { get; set; }

        public string whatwedoAct { get; set; }
    }
}
