using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Transfer
{
    public class ResumenPagodt
    {
        /*Aqui se mostrará la lista de resumen de Pago con el id_rpago*/
        public int id_rpago { get; set; }
        public int id_detalle_pedido { get; set; }
        public int id_cupon { get; set; }
        public string total_product { get; set; }
        public string costo_producto { get; set; }
        public string propina { get; set; }
        public string tarifa_servicio { get; set; }
        public string total_cobrar { get; set; }
     
        

    }
}