using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class About
    {
        [Key]
        public int aboutID { get; set; }

        public string aboutDetails { get; set; }

        [StringLength(250)]
        public string aboutPhotoUrl { get; set; }

        public DateTime aboutDate { get; set; }

        public bool aboutAct { get; set; }

    }
}
