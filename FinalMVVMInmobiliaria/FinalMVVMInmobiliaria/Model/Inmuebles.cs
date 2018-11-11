using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMVVMInmobiliaria.Model
{
    public class Inmuebles
    {
        public int ID { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int IDVendedor { get; set; }
        public string Direccion { get; set; }
        public string Ambientes { get; set; }
        public int Precio { get; set; }
        public Boolean Reservado { get; set; }

    }
}
