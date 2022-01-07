using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Transfer
{
    public class EntregaProductodt
    {
      /*Aqui vamos a obtener el tiempo de entrega del producto*/
        public int id_tiempEntrega { get; set; }
        public int id_pedido { get; set; }
        public string direccion_entrega { get; set; }
        public string entrega_estimada { get; set; }
    }
}