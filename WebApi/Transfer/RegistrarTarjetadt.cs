using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Transfer
{
    public class RegistrarTarjetadt
    {
        public int id_rTarjeta { get; set; }
        public string n_tarjeta { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string fecha_tarjeta { get; set; }
        public string cvv { get; set; }
    }
}