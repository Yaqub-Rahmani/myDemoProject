using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EmployeeUser
    {
        [Key]
        public int employeeID { get; set; }

        [StringLength(100)]
        public string employeeUserName { get; set; }

        [StringLength(100)]
        public string employeeLastName { get; set; }

        [StringLength(100)]
        public string employeeNikName { get; set; }

        [StringLength(100)]
        public string employeeEmail { get; set; }

        [StringLength(10)]
        public string employeeMoneyAz { get; set; }

        [StringLength(20)]
        public string employeeMobile { get; set; }

        [StringLength(200)]
        public string employeeSkills { get; set; }

        [StringLength(250)]
        public string employeeAddress { get; set; }
        
        [StringLength(250)]
        public string employeePhoto { get; set; }

        public DateTime SavedateTime { get; set; }

        public bool employeeAct { get; set; }

        public int catagoryID { get; set; }
        public virtual Catagory Catagory { get; set; }
    }
}
