//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facturacion
    {
        public int IdFactura { get; set; }
        public string Observaciones { get; set; }
        public string Item { get; set; }
        public decimal Valor { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
