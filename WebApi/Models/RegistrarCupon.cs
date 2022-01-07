using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfer;

namespace WebApi.Models
{
    public partial class Cupón_descuento
    {
        public static RegistrarCupoDescuentodt RegistrarCupon(RegistrarCupoDescuentodt registrarCupondt)
        {
            bdrappiEntities2 db = new bdrappiEntities2();
             Cupón_descuento registrarCupondescuento = new Cupón_descuento()
            {
                id_cupon = registrarCupondt.id_cupon,
                codig_cupon = registrarCupondt.codig_cupon
            };
            db.Cupón_descuento.Add(registrarCupondescuento);
            db.SaveChanges();
            registrarCupondt.id_cupon = registrarCupondescuento.id_cupon;
            return registrarCupondt;
        }
    }
}