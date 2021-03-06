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
    
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            this.Detalle_Pedido = new HashSet<Detalle_Pedido>();
            this.EntregaProducto = new HashSet<EntregaProducto>();
            this.facturacion = new HashSet<facturacion>();
            this.TiempEntregaProd = new HashSet<TiempEntregaProd>();
            this.TomaPedido = new HashSet<TomaPedido>();
        }
    
        public int id_pedido { get; set; }
        public int id_sucursal { get; set; }
        public int id_usuario { get; set; }
        public string estado_pedido { get; set; }
        public Nullable<System.DateTime> Tiempo_preparacion { get; set; }
        public Nullable<double> propina { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Pedido> Detalle_Pedido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntregaProducto> EntregaProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<facturacion> facturacion { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiempEntregaProd> TiempEntregaProd { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TomaPedido> TomaPedido { get; set; }
    }
}
