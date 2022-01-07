using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfer;

namespace WebApi.Models
{
    public partial class ListaPago
    {
       public static IEnumerable<ListaMetodoPagodt> ListadeMetodoPago()
        {
            bdrappiEntities2 db = new bdrappiEntities2();
            var list = from b in db.ListaPago
                       select new ListaMetodoPagodt()
                       {
                           id_listaPago = b.id_listaPago,
                           //id_Mpago = b.id_Mpago,
                           tipo1 = b.tipo1,
                           tarjeta1 = b.tarjeta1,
                           tarjeta2 = b.tarjeta2,
                           tarjeta3 = b.tarjeta3,
                           tarjeta4 = b.tarjeta4
                       };
            return list;
        }
    }
}