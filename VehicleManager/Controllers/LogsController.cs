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
    /// rest service for vehicles's management
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        /// <summary>
        /// conversion of the json file to list and checking of the specifications
        /// </summary>
        /// <returns>list of specified vehicles</returns>
        // GET: api/logs
        [HttpGet]
        public IEnumerable<Log> Get()
        {
            // Imports the Json List
            LogList jsonLog = new();

            return jsonLog.Logs;
        }

        /// <summary>
        /// conversion of the json file to list and checking of the specifications
        /// </summary>
        /// <returns>list of specified logs</returns>
        // GET: api/logs/user
        [HttpGet("{user}")]
        public IEnumerable<Log> Get(string user)
        {
            // Imports the Json List
            LogList jsonLog = new();

            // New List that imports the asked logs from the json list
            List<Log> logs = new();

            foreach (Log log in jsonLog.Logs.Where(x => x.User.Equals(user)))
            {
                logs.Add(log);
            }

            return logs;
        }
    }
}
