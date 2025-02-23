using EntityFrameWork_1.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EntityFrameWork_1.Controllers
{
    [ApiController]
    [Route("EntityFrameWork")]
    public class EntityFrameWorkController : ControllerBase
    {
        [HttpGet]
        [Route("AddEntry")]
        public HttpResponseMessage TableEntry()
        {
            HttpResponseMessage result = new HttpResponseMessage();

            CreateProduct(1, "Laptop", 800.00m, "4444422");
            CreateProduct(2, "Laptop1", 330.00m, "4444424");
            CreateProduct(3, "Lapto2", 550.00m, "4444426");


            return result;
        }

        [HttpGet]
        [Route("ReadEntry")]
        public IActionResult ReadTableEntry()
        {
            //HttpResponseMessage result = new HttpResponseMessage();

            var resultproduct = ReadProducts();
            if (resultproduct != null)
            {
                return Ok(resultproduct);
            }
            else
            {
                return BadRequest("Something Went Wrong");
            }

        }

        [HttpDelete]
        [Route("ReadEntry/productId={productId}")]
        public IActionResult DeleteTableEntry(string productId)
        {
            var status = DeleteTableEntryValue(productId);
            if (status)
            {
                return Ok("Product Deleted Successfully");
            }
            else
            {
                return NotFound();
            }
        }

        private bool DeleteTableEntryValue(string productId)
        {
            using (var context = new ApplicationDbContext())
            {
                var p = context.Products.ToList();
                foreach (var product in p)
                {
                    if (product.ProductId.Equals(productId))
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();
                        return true;
                    }
                }
            }
            return false;
        }

        private void CreateProduct(int id, string v1, decimal v2, string ProductId)
        {
            using (var context = new ApplicationDbContext())
            {
                var products = new Product
                {
                    Id = id,
                    Name = v1,
                    Price = v2,
                    ProductId = ProductId
                };
                context.Products.Add(products);
                context.SaveChanges();
                Console.WriteLine("$ProductName '{v1}' added");
            }
        }

        /// <summary>
        /// Return List<Product></Product>
        /// </summary>
        /// <returns></returns>
        private List<Product> ReadProducts()
        {
            List<Product> products = new List<Product>();
            using (var context = new ApplicationDbContext())
            {
                var p = context.Products.ToList();
                products.AddRange(p);
            }
            return products;
        }


    }
}
