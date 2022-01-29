using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Company
    {
        [Key]
        public int companyID { get; set; }

        [StringLength(100)]
        public string companyName { get; set; }

        [StringLength(150)]
        public string companyBoss { get; set; }

        [StringLength(100)]
        public string companyEmail { get; set; }

        [StringLength(200)]
        public string companyAddress { get; set; }

        [StringLength(20)]
        public string companyPhone { get; set; }

        [StringLength(200)]
        public string companyLogoPhoto { get; set; }

        [StringLength(20)]
        public string companyMobile { get; set; }

        [StringLength(20)]
        public string companyFaxNo { get; set; }

        public DateTime companySaveDate { get; set; }

        public int catagoryID { get; set; }
        public virtual Catagory Catagory { get; set; }
    }
}
