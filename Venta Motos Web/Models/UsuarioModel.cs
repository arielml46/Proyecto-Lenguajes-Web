using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Venta_Motos_Web.Models
{
    public class LogeoModel
    {
        [Required]//Que el campo es requerido
        [StringLength(100)]//Longitud maxima del campo
        [Display(Name = "Nombre de usuario:")]
        //le indicamos que no se le permite caracteres extraños
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracteres inválidos")]
        public string usu_nombre { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 2)]
        [Display(Name = "Contraseña:")]
        public string usu_password { get; set; }

        [Display(Name = "Recordar mi cuenta")]
        public bool RememberMe { get; set; }

    }
}