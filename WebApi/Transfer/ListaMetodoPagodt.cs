using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Transfer
{
    public class ListaMetodoPagodt
    { 
        /*Obtener los datos de Metodo de Pago (Efectivo - Tarjeta)*/
        public int id_listaPago { get; set; }
        //public int id_Mpago { get; set; }
        public string tipo1 { get; set; }
        public string tarjeta1 { get; set; }
        public string tarjeta2 { get; set; }
        public string tarjeta3 { get; set; }
        public string tarjeta4 { get; set; }

    }
}