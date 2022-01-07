using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfer;

namespace WebApi.Models
{
    public partial class RegistrarTarjeta
    {
        public static RegistrarTarjetadt RegistrodeTarjeta(RegistrarTarjetadt registrardt)
        {
            bdrappiEntities2 db = new bdrappiEntities2();
            RegistrarTarjeta registrar = new RegistrarTarjeta()
            {
                n_tarjeta = registrardt.n_tarjeta,
                nombre = registrardt.nombre,
                apellido = registrardt.apellido,
                fecha_tarjeta = registrardt.fecha_tarjeta,
                cvv = registrardt.cvv
            };
            db.RegistrarTarjeta.Add(registrar);
            db.SaveChanges();
            registrardt.id_rTarjeta = registrardt.id_rTarjeta;
            return registrardt;
       }
    }
}