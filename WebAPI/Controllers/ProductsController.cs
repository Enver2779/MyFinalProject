using Business.Abtract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
           
            var result=_productService.GetById(id);
            if (result.Seccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
            
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var result = _productService.GetAll();
            if (result.Seccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }
        [HttpPost]
        public IActionResult Post(Product product)
        {
            var result = _productService.Add(product);
            if (result.Seccess)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
