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
    
    public partial class Tbl_Tipo_Pago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Tipo_Pago()
        {
            this.Tbl_Facturas = new HashSet<Tbl_Facturas>();
            this.Tbl_Pago_Cheque = new HashSet<Tbl_Pago_Cheque>();
        }
    
        public string tipo_pago { get; set; }
        public string nombre_pago { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Facturas> Tbl_Facturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Pago_Cheque> Tbl_Pago_Cheque { get; set; }
    }
}
