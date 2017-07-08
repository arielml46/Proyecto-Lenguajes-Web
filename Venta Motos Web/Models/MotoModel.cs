using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Venta_Motos_Web.Models
{
    public class MotoModel
    {
        public string id_Moto { get; set; }
        public string tipo { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        public decimal precio_fabrica { get; set; }
    }
}