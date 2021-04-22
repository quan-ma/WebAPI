using System;
using Microsoft.AspNetCore.Mvc;

namespace PlatformDemo.Controller
{
    [ApiController]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        [Route("api/items")]
        public IActionResult Get()
        {
            return Ok("Got items");
        }

        [HttpPost]
        [Route("api/item")]
        public IActionResult Post()
        {
            return Ok("Created item");
        }

        [HttpPost]
        [Route("/api/item/{id}/tickets")]
        public IActionResult Post(string id, string tId)
        {
            return Ok($"created item {id} with ticket #{tId}");
        }

        [HttpPut]
        [Route("api/item/{id}")]
        public IActionResult Put(string id)
        {
            return Ok($"updating ticket {id}");
        }
    }
}
