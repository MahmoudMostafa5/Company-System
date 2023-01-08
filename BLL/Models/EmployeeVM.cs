using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.DAL.Entities;

namespace BLL.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Please Enter Name ")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter Salary")]
        [Range(2000,10000,ErrorMessage ="Salary Must be From 2000 To 10000")]
        public double Salary { get; set; }
        
        [RegularExpression("[0-9]{5}-[a-zA-z]{1,10}-[a-zA-z]{1,10}-[a-zA-z]{1,10}",ErrorMessage ="Ex. 12-Stret-BeniSuef-Egypt")]
        public string Address { get; set; }
        public DateTime HierDate { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
