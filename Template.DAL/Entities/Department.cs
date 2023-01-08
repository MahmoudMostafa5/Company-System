using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Template.DAL.Entities
{
    [Table("Department")]
    public class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50) , Required]
        public string Name { get; set; }
        [StringLength(50) , Required]
        public double Code { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
