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
    
    public partial class toppings
    {
        public int id_topping { get; set; }
        public string nom_topping { get; set; }
        public string descrip_topping { get; set; }
        public Nullable<double> precio_topping { get; set; }
        public int id_producto { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
