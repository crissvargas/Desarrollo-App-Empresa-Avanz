using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre{ get; set; }
        public string Descripcion { get; set; }
        public string PrecioVenta { get; set; }
        public string FechaCreacion { get; set; }
        public string EstaActivo { get; set; }
        public string FechaVencimiento{ get; set; }
        public string IGV { get; set; }  //IGV=PrecioVenta*0.18
        public bool IsEnable { get; set; }
        public DateTime CreatedON { get; set; }
    }
}
