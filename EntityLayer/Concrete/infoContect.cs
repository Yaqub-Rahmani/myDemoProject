using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class infoContect
    {
        [Key]
        public int mcontectID { get; set; }
        
        public string mcontectAciklama { get; set; }

        [StringLength(250)]
        public string mcontectAddres { get; set; }

        [StringLength(17)]
        public string mcontectPhone { get; set; }

        [StringLength(20)]
        public string mcontectFaxNo { get; set; }

        [StringLength(100)]
        public string mcontectEmail { get; set; }

        public DateTime mcontectDate { get; set; }

        public bool mcontectAct { get; set; }
    }
}
