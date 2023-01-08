using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.DAL.Entities
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }
        public double Salary { get; set; }
        [StringLength(50), Required]
        public string Address { get; set; }
        public DateTime HierDate { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        //Eazy Load => Return data from emp table only => default
        //Eager Load => Return data from emp table + dep table => to use write virtual
    }
}
