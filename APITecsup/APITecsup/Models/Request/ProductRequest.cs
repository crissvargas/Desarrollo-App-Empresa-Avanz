using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITecsup.Models.Request
{
    public class ProductRequest
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string PrecioVenta { get; set; }
        public string FechaCreacion { get; set; }
        public string EstaActivo { get; set; }
        public string FechaVencimiento { get; set; }
        public string IGV { get; set; }  
    }
}