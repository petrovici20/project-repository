using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManager.AppData;
using VehicleManager.Models;

namespace VehicleManager.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        // GET api/vehicles/{ "User" : "###", "Zone" : "###", "Date" : "####/##/##"}
        [HttpGet("{request}")]
        public IEnumerable<Vehicle> Get(RequestSpecification request)
        {
            try
            {
                // Imports the Json List
                VehicleList jsonVehicleList = new();

                // New List that imports the asked vehicles from the json list
                List<Vehicle> vehicles = new();

                foreach (Vehicle vehicle in jsonVehicleList.Vehicles.Where(x => x.Zone.Equals(request.Zone) && x.DateAvailable.Equals(request.Date)))
                {
                    vehicles.Add(vehicle);
                }

                // Creates a Log of the request
                new Log { User = request.User, RequestTime = DateTime.Now.Date };

                return vehicles;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
