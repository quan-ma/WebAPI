using System;
using Microsoft.AspNetCore.Mvc;
using PlatformDemo.Models;

namespace PlatformDemo.Controller
{
    [ApiController]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        [Route("api/projects")]
        public IActionResult Get()
        {
            return Ok("Got projects");
        }

        [HttpGet]
        [Route("api/projects/{id}/tickets/")]
        public IActionResult Get(string id, string tid)
        {
            if( tid == null)
            {
                return Ok($"Getting all tickets from project #{id}");
            }
            else
            {
                return Ok($"Getting project #{id} with ticket #{tid}");
            }
            
        }

        [HttpPut]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult Put([FromQuery]Ticket ticket)
        {
            if (ticket == null) return BadRequest("Parameters are not provided properly");
            if(ticket.TicketId == 0)
            {
                return Ok($"Updating all tickets for project #{ticket.ProjectId}");
            }
            else
            {
                return Ok($"Updating ticket #{ticket.TicketId} for project #{ticket.ProjectId} title: {ticket.Title}, description {ticket.Description}");
            }
            
        }

    }
}
