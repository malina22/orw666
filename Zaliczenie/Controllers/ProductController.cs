using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zaliczenie.Models;

namespace Zaliczenie.Controllers
{
    public class ProductController : ApiController
    {
        private List<Product> products = new List<Product>() 
        { 
            new Product{Id=1,Name="koszulka",Price=60,Qty=6},
            new Product{Id=2,Name="Buty",Price=90,Qty=6},
            new Product{Id=3,Name="Rękawiczki",Price=90,Qty=6},
            new Product{Id=4,Name="Czapki",Price=90,Qty=6},
            new Product{Id=5,Name="KOrki",Price=90,Qty=6},
            new Product{Id=6,Name="Kamizelka",Price=90,Qty=6}
        };
        public IEnumerable<Product> Get()
        {
            return products.ToList();
        }
        public IHttpActionResult Get(int id)
        {
            var product = products.Where(x => x.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}
