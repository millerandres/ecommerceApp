using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ecommerceApp.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio ")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser de almenos {1} caracteres")]
        [Display(Name = "City")]

        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio ")]
        [Display(Name = "Departamento")]
        public int DepartmentId { get; set; }

        public virtual Department Department{ get; set; }
    }
}