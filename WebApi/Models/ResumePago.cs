using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfer;

namespace WebApi.Models
{
    public partial class Resumen_Pago
    {
        public static ResumenPagodt ListadeResumenPago(int id_rpago)
        {
            bdrappiEntities2 db = new bdrappiEntities2();
            var obj = db.Resumen_Pago.Select(b =>
                        new ResumenPagodt() {
                            id_rpago = b.id_rpago,
                            id_detalle_pedido = b.id_detalle_pedido,
                            id_cupon = b.id_cupon,
                            total_product = b.total_productos,
                            costo_producto = b.costo_producto,
                            propina = b.Propina,
                            tarifa_servicio = b.tarifa_servicio,
                            total_cobrar = b.total_cobrar
                          
                        }).SingleOrDefault(b => b.id_rpago == id_rpago);
            return obj;
        }
    }
}