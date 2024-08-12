using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace ecommerceApp.Models
{
    public class Department
    {
        
          [Key]
          public int DepartmentId { get; set; }

          [Required(ErrorMessage ="El campo {0} es obligatorio ")]
          [MaxLength(50, ErrorMessage = "El campo {0} debe ser de almenos {1} caracteres")]
          [Display(Name = "Department")]
          public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}