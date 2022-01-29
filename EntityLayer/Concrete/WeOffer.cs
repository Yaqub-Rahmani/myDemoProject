using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WeOffer
    {
        [Key]
        public int whatweofferID { get; set; }

        [StringLength(1000)]
        public string whatweofferText { get; set; }

        [StringLength(250)]
        public string whatwePhotoofferUrl { get; set; }

        public DateTime whatweofferDate { get; set; }

        public string whatweofferAct { get; set; }
    }
}
