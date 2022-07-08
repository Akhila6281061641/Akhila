using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticketservices.Models;
using Ticketservices.Viewmodel;

namespace Ticketservices.Controllers
{
    [Route("api/1.0/flight/ticket")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        [HttpGet]

        public IActionResult getData(int pnr)
        {
            return Ok("ticket");
        }
        FlightDBContext db;
        public TicketController(FlightDBContext _db)
        {
            db = _db;
        }
        
       


        
    }

}
