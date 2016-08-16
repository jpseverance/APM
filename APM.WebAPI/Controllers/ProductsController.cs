using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APM.WebAPI.Models;
using System.Web.Http.Cors;

namespace APM.WebAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.Retrieve();
        }

        public IEnumerable<Product> Get(string search)
        {
            ProductRepository productRepository = new ProductRepository();
            List<Product> products = productRepository.Retrieve();
            IEnumerable<Product> result = products.Where( product => product.ProductCode.Contains( search ) );
            return result;
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
