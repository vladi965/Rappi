using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Transfer;

namespace WebApi.Controllers
{
    public class RappiPagoController : ApiController
    {
        [HttpGet]
        [Route("api/RappiPago/ListadeMetodoPago")]
        public IEnumerable<ListaMetodoPagodt> ListadeMetodoPago()
        {
            return ListaPago.ListadeMetodoPago();
        }

        [HttpPost]
        [Route("api/RappiPago/RegistrodeTarjeta")]
        public RegistrarTarjetadt RegistrodeTarjeta(string n_tarjeta, string nombre, string apellido, string fecha_tarjeta, string cvv)
        {
            RegistrarTarjetadt obj = new RegistrarTarjetadt()
            {
                n_tarjeta = n_tarjeta,
                nombre = nombre,
                apellido = apellido,
                fecha_tarjeta = fecha_tarjeta,
                cvv = cvv
            };
            return RegistrarTarjeta.RegistrodeTarjeta(obj);
        }

        [HttpGet]
        [Route("api/RappiPago/ObtenerCoordenadaProducto")]
        public EntregaProductodt ObtenerCoordenadaProducto(string direccion_entrega)
        {
            return TiempEntregaProd.ObtenerCoordenadaProducto(direccion_entrega);
        }

        [HttpPost]
        [Route("api/RappiPago/RegistrodePropina")]
        public RegistrarPropinadt RegistrodePropina(int id_pedido, string monto)
        {
            RegistrarPropinadt obj = new RegistrarPropinadt()
            {
                id_pedido = id_pedido,
                monto = monto
            };
            return PagoRappitendero.RegistrodePropina(obj);
        }


        [HttpPost]
        [Route("api/RappiPago/RegistrodeCupon")]
        public RegistrarCupoDescuentodt RegistrodeCupon(int id_cupon, string codig_cupon)
        {
            RegistrarCupoDescuentodt obj = new RegistrarCupoDescuentodt()
            {
               id_cupon = id_cupon,
               codig_cupon = codig_cupon
            };
            return Cupón_descuento.RegistrarCupon(obj);
        }


        [HttpGet]
        [Route("api/RappiPago/ListadeResumenPago")]
        public ResumenPagodt ListadeResumenPago(int id_rpago)
        {
            return Resumen_Pago.ListadeResumenPago(id_rpago);
        }



    }
}
