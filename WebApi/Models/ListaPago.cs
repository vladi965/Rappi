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
    
    public partial class ListaPago
    {
        public int id_listaPago { get; set; }
        public int id_Mpago { get; set; }
        public string tipo1 { get; set; }
        public string tarjeta1 { get; set; }
        public string tarjeta2 { get; set; }
        public string tarjeta3 { get; set; }
        public string tarjeta4 { get; set; }
    
        public virtual Método_Pago Método_Pago { get; set; }
    }
}
