using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using VisitManager.Models;

namespace VisitManager.Controllers
{
    /// <summary>
    /// REST Controller for the CRUD methods
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class VisitsController : ControllerBase
    {
        // Connection String
        readonly SqlConnection connection = new(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");

        /// <summary>
        /// Gets the visits from the database
        /// </summary>
        /// <returns>result string</returns>
        [HttpGet]
        public string Get()
        {
            // Creates empty data table
            DataTable table = new();

            try
            {
                // Get all Visits query
                using (SqlCommand command = new("SELECT * FROM Visit", connection))
                {
                    using (SqlDataAdapter adapter = new(command))
                    {
                        connection.Open();
                        // Fill the table with the deliveries
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            // Converts to Json
                            return JsonConvert.SerializeObject(table);
                        }
                        else
                        {
                            return "No data found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

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
