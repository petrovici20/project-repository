using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace VisitManager.Controllers
{
    /// <summary>
    /// Could not fix the XML data, so using REST GET for the Dashboard
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GambiarraController : ControllerBase
    {
        // Connection String
        readonly SqlConnection connection = new(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");

        /// <summary>
        /// Gets the patients from the database
        /// </summary>
        /// <returns>Json string with deliveries</returns>
        // GET: api/deliveries
        [HttpGet]
        public string Get()
        {
            // Creates empty data table
            DataTable table = new();

            try
            {
                // Get all Deliveries query
                using (SqlCommand command = new("SELECT * FROM Delivery", connection))
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
    }
}
