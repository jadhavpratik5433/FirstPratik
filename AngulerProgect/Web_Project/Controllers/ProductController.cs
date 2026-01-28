using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Project.Data;
using Web_Project.Model;

namespace Web_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContexts _context;
        public ProductController(AppDbContexts contexts)
        {
            _context = contexts;

        }
        [HttpPost]
        public IActionResult CreateProduct(Product Products)
        {
            _context.Products.Add(Products);
            _context.SaveChanges();
            return Ok("Product add successfuly");
        }

     
        [HttpGet]
        public IActionResult GetProduct()
        {
            try
            {
                var products = _context.Products.ToList();
                if (products.Count == 0)
                {
                    return NotFound("No products found.");
                }
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving products: " + ex.Message);
            }
        }
        [HttpPut("UpdateProduct/{id}")]
        public IActionResult UpdateProduct(Product Products, int id)
        {
            try
            {
                var isrecord = _context.Products.SingleOrDefault(n => n.Id == id);
                if (isrecord == null)
                {
                    return NotFound("record not availble");
                }
                isrecord.Name = Products.Name;
                isrecord.Description = Products.Description;
                isrecord.Price = Products.Price;

                _context.SaveChanges();
                return Ok("Product update successfuly");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "internal server error" + ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                var isrecord = _context.Products.SingleOrDefault(n => n.Id == id);
                if (isrecord == null)
                {
                    return NotFound("record not availble");
                }
                _context.Products.Remove(isrecord);
                _context.SaveChanges();
                return Ok("Product delete successfuly");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "internal server error" + ex.Message);
            }
        }
    }
}
