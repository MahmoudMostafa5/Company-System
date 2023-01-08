using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class DepartmentVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Name")]
        [MaxLength(50,ErrorMessage ="Max Length 50 Char")]
        [MinLength(3,ErrorMessage = "Min Length 3 Char")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter Code")]
        [Range(1,100,ErrorMessage =("Code Range Between 1 , 100"))]
        public double Code { get; set; }
    }
}
