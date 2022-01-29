using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Catagory
    {
        [Key]
        public int catagoryID { get; set; }

        [StringLength(100)]
        public string catagoryName { get; set; }

        [StringLength(500)]
        public string catagoryAciklama { get; set; }

        public bool catagoryAct { get; set; }

        public ICollection<Company> Companies { get; set; }

        public ICollection<EmployeeUser> EmployeeUsers { get; set; }
    }
}
