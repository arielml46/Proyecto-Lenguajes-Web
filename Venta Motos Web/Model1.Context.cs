﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_Ventas_AutomovilesContext : DbContext
    {
        public DB_Ventas_AutomovilesContext()
            : base("name=DB_Ventas_AutomovilesContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Clientes> Tbl_Clientes { get; set; }
        public virtual DbSet<Tbl_Detalles_Facturas> Tbl_Detalles_Facturas { get; set; }
        public virtual DbSet<Tbl_Facturas> Tbl_Facturas { get; set; }
        public virtual DbSet<Tbl_Motos> Tbl_Motos { get; set; }
        public virtual DbSet<Tbl_Pago_Cheque> Tbl_Pago_Cheque { get; set; }
        public virtual DbSet<Tbl_Tipo_Pago> Tbl_Tipo_Pago { get; set; }
        public virtual DbSet<Tbl_Usuarios> Tbl_Usuarios { get; set; }
    }
}
