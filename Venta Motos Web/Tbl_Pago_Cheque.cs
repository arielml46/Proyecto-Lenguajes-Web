//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Venta_Motos_Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Pago_Cheque
    {
        public string id_tipo_pago { get; set; }
        public string cheque_numero { get; set; }
        public string nombre_banco { get; set; }
    
        public virtual Tbl_Tipo_Pago Tbl_Tipo_Pago { get; set; }
    }
}