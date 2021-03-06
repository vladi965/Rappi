//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rappitendero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rappitendero()
        {
            this.CalificacionRappitendero = new HashSet<CalificacionRappitendero>();
            this.EntregaProducto = new HashSet<EntregaProducto>();
            this.Transporte = new HashSet<Transporte>();
        }
    
        public int id_rappitendero { get; set; }
        public int id_usuario { get; set; }
        public byte[] foto_dnidel { get; set; }
        public byte[] foto_dnitra { get; set; }
        public Nullable<System.DateTime> fecha_vencimiento { get; set; }
        public string Descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalificacionRappitendero> CalificacionRappitendero { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntregaProducto> EntregaProducto { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transporte> Transporte { get; set; }
    }
}
