using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;
using WebApi.Transfer;

namespace WebApi.Models
{
    public partial class TiempEntregaProd
    {
        public static EntregaProductodt ObtenerCoordenadaProducto(string direccion_entrega)
        {
            bdrappiEntities2 db = new bdrappiEntities2();
            var obj = db.TiempEntregaProd.Select(b =>
                new EntregaProductodt()
                {
                    id_tiempEntrega = b.id_tiempEntrega,
                    id_pedido = b.id_pedido,
                    direccion_entrega = b.direccion_entrega,
                    entrega_estimada = b.entrega_estimada
                }).SingleOrDefault(b => b.direccion_entrega == direccion_entrega);
            return obj;
        }


    }
}