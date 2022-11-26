using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductoService
    {
        //Listar Productos 
        public List<Producto> Get()
        {
            using (var context = new ExampleContext())
            {
                return context.Producto.Where(x => x.IsEnable == true).ToList();
            }
        }
        //Listar por ID
        public Producto GetById(int id)
        {
            using (var context = new ExampleContext())
            {
                return context.Producto.Find(id);
            }
        }

        //Insertar Productos
        public void Insert(Producto producto)
        {
            using (var context = new ExampleContext())
            {

                producto.IsEnable = true;
                producto.CreatedON = DateTime.Today;
                context.Producto.Add(producto);
                context.SaveChanges();
            }
        }
    }
}
