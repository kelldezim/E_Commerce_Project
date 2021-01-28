using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts(){
            //it needs to by async because many requests could be proccess in the same time
            //using abstract repo is designed for scalible app

            var products = await _repo.GetProductsAsync(); // performing select query on our db

            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id){
            // var product = await _context.Products.SingleOrDefaultAsync(n => n.Id == id);
            // if(product == null)
            //     return BadRequest();
            
            return await _repo.GetProductByIdAsync(id);
        }
    }
}