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
    
    public partial class N_Tarjeta_Pago
    {
        public int id_ntpago { get; set; }
        public int id_Mpago { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string número_tarjeta { get; set; }
        public Nullable<System.DateTime> fecha_expiración { get; set; }
        public string codigo_cvv { get; set; }
        public int id_cupon { get; set; }
    
        public virtual Cupón_descuento Cupón_descuento { get; set; }
        public virtual Método_Pago Método_Pago { get; set; }
    }
}