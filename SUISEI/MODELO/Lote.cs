//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SUISEI.MODELO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lote
    {
        public int id_lote { get; set; }
        public int l_id_producto { get; set; }
        public Nullable<int> l_stock { get; set; }
        public Nullable<System.DateTime> l_fecha_produccion { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}