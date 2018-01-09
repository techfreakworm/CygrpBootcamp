﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using WebAPIdemo.Models;
using System.Data;

namespace WebAPIdemo.Controllers
{
    public class ProductsController : ApiController
    {
        ProductContext db = new ProductContext();
        public IEnumerable<Product> GetAllProducts()
        {
            return db.Products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var products = db.Products;
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public HttpResponseMessage PostProduct(Product product)
        {
            var response = Request.CreateResponse<Product>(HttpStatusCode.Created, product);
            // Product product = JsonConvert.DeserializeObject<Product>(JSONData);
            //string uri = Url.Link("DefaultApi", id = product.Id);

            db.Products.Add(product);
            db.SaveChanges();
            return response;
     

        }

        public void DeleteProduct(int id)
        {
            Product item = db.Products.Where(p => p.Id==id).FirstOrDefault<Product>();
            db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
        public void PutProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            else
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }
    }
}
