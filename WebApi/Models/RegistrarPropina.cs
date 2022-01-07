using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfer;

namespace WebApi.Models
{
    public partial class PagoRappitendero
    {
        public static RegistrarPropinadt RegistrodePropina(RegistrarPropinadt registrarPropinadt)
        {
            bdrappiEntities2 db = new bdrappiEntities2();
            PagoRappitendero registrarRappi = new PagoRappitendero()
            {
                id_pedido = registrarPropinadt.id_pedido,
                monto = registrarPropinadt.monto
            };
            db.PagoRappitendero.Add(registrarRappi);
            db.SaveChanges();
            registrarPropinadt.id_pagoRappi = registrarPropinadt.id_pagoRappi;
            return registrarPropinadt;
        }
    }
}
