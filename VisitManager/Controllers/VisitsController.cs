using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using VisitManager.Models;

namespace VisitManager.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class VisitsController : ControllerBase
    {
        // Connection String
        readonly SqlConnection connection = new(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visit"></param>
        // POST api/visits
        [HttpPost]
        public ActionResult<string> Post([FromBody] Visit visit)
        {
            try
            {
                // Adds a visit query
                SqlCommand command = new("INSERT INTO Visit (Patient_Utente, Visitor_Name, Arrival, Departure) " +
                                     "VALUES (@Utente, @Name, @Arrival, @Departure)", connection);
                command.Parameters.AddWithValue("@Utente", visit.PatientUtente);
                command.Parameters.AddWithValue("@Name", visit.VisitorName);
                command.Parameters.AddWithValue("@Arrival", visit.ArrivalTime);
                command.Parameters.AddWithValue("@Departure", visit.DepartureTime);

                connection.Open();

                // Inserts the visit in the database
                int rows = command.ExecuteNonQuery();
                if(rows > 0)
                {
                    return Ok("Visit Logged");
                }
                else
                {
                    return BadRequest("Failed to insert the visit");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
