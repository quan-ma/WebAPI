using System;
using Microsoft.AspNetCore.Mvc;

namespace PlatformDemo.Controller
{
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [HttpGet] //routing attribute
        [Route("api/tickets")] //return all of the tickets
        public IActionResult Get()//method to get - generic return type
        {
            return Ok("Reading all the tickets");
        }

        [HttpGet] 
        [Route("api/tickets/{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Reading ticket #{id}");
        }

        [HttpPost]
        [Route("api/tickets/")]
        public IActionResult Post(int id)
        {
            return Ok($"Creating a ticket");
        }

        [HttpPut]
        [Route("api/tickets/{id}")]
        public IActionResult Put()
        {
            return Ok($"Updating a ticket");
        }

        [HttpDelete]
        [Route("api/tickets/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting ticket #{id}");
        }
    }
}
