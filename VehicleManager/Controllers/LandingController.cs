using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace VehicleManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandingController : ControllerBase
    {
        // GET: api/landing
        [HttpGet]
        public string Get()
        {
            return $"Landed {DateTime.Now}";
        }
    }
}
