using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Venta_Motos_Web.Models
{
    public class ClientesModel
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "El valor {0} no es válido, tipo numero")]
        //el nombre a mostrar en la view
        [Display(Name = "Cédula:")]
        public string cli_Cedula { get; set; }

        [Required]//Que el campo es requerido
        [StringLength(100)]//Longitud maxima del campo
        [Display(Name = "Nombre del Cliente:")]
        //le indicamos que no se le permite caracteres extraños
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracteres inválidos")]
        public string cli_Nombre { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "El valor {0} no es válido, tipo numero")]
        //el nombre a mostrar en la view
        [Display(Name = "Teléfono:")]
        public string cli_Telefono { get; set; }

        [Required]
        [StringLength(120)]
        //expresion que solo permite letras
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,120}$", ErrorMessage = "Caracteres inválidos.")]
        [Display(Name = "Dirección:")]
        public string cli_Direccion { get; set; }
    }
}