using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contect
    {
        [Key]
        public int contectID { get; set; }

        [StringLength(100)]
        public string contectName { get; set; }

        [StringLength(100)]
        public string contectSubject { get; set; }

        [StringLength(100)]
        public string contectEmail { get; set; }

        public DateTime contectDate { get; set; }

        public string contectMessage { get; set; }
    }
}
