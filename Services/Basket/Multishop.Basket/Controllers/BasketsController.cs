﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Multishop.Basket.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = new List<string>();
            return Ok(values);
        }
    }
}

