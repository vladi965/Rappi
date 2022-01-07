using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Transfer
{
    public class RegistrarPropinadt
    {
        /*Aqui vamos a insertar las propinas*/
        /*Luego vamos a obtener si se transferio la propina satisfactoriamente*/
        public int id_pagoRappi { get; set; }
        public int id_pedido { get; set; }
        public string monto { get; set; }
       
    }
}