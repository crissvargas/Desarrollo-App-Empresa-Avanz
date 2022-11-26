using APITecsup.Models.Request;
using APITecsup.Models.Response;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace APITecsup.Controllers
{
    public class ProductController : ApiController
    {
        // GET: Productos
        public List<ProductResponse> Get()
        {

            var service = new ProductoService();
            var producto = service.Get();

            //Convert Domaint to Response
            var response = producto.Select(x => new ProductResponse
            {
                info = string.Concat(x.Nombre, " ", x.Descripcion)
            }).ToList();

            return response;
        }
        [HttpPost]
        public bool Insert(ProductRequest request)
        {
            var response = true;
            try
            {
                var service = new ProductoService();
                service.Insert(new Domain.Producto
                {
                    Nombre = request.Nombre,
                   Descripcion = request.Descripcion
                });
            }
            catch (Exception)
            {
                //log ex
                response = false;
            }
            return response;
        }

    }
}