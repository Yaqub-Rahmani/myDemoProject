using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AdminLar
    {

        [Key]
        public int AdminID { get; set; }

        [StringLength(100)]
        public string AdminUserName { get; set; }

        [StringLength(100)]
        public string AdminLastName { get; set; }

        [StringLength(2)]
        public string AdminRoll { get; set; }

        public bool AdminAct { get; set; }

        [StringLength(100)]
        public string AdminEmail { get; set; }

        [StringLength(100)]
        public string AdminPassword { get; set; }

        [StringLength(400)]
        public string AdminPhotoUrl { get; set; }
    }
}
