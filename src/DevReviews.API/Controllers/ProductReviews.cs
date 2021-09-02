using DevReviews.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReviews.API.Controllers
{
    [ApiController]
    [Route("api/products/{productId}/productReviews")]
    public class ProductReviews : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById(int productId, int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(int productId, AddProductReviewInputModel inputModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1, productId = 2 });
        }
    }
}
