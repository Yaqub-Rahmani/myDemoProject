using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HomeTopCont
    {
        [Key]
        public int homtopcontID { get; set; }

        [StringLength(500)]
        public string homtopcontText { get; set; }

        [StringLength(400)]
        public string homtopcontPhotoUrl { get; set; }

        public DateTime homtopcont { get; set; }

        public bool homtopcontAct { get; set; }
    }
}
