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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Venta = new HashSet<Venta>();
        }
    
        public int id_cliente { get; set; }
        public string c_nombres { get; set; }
        public string c_paterno { get; set; }
        public string c_materno { get; set; }
        public Nullable<int> c_edad { get; set; }
        public string c_sexo { get; set; }
        public string c_direccion { get; set; }
        public string c_telefono { get; set; }
        public string c_dni { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
