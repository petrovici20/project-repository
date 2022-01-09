using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SupplyManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace SupplyManager.Controllers
{
    /// <summary>
    /// REST Service for the management of Requests
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        // Connection String
        readonly SqlConnection connection = new(@"Data Source=.;Initial Catalog=Central_Compras_Estado;Integrated Security=True");

        /// <summary>
        /// Gets the requests from the database
        /// </summary>
        /// <returns>Json string with requests</returns>
        // GET api/requests
        [HttpGet]
        public string Get()
        {
            // Creates empty data table
            DataTable table = new();

            try
            {
                // Get all Deliveries query
                using (SqlCommand command = new("SELECT * FROM Request", connection))
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
        /// Gets the requests from the database with a specific keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns>Json string with requests</returns>
        // GET api/requests/###
        [HttpGet("{keyword}")]
        public string Get(string keyword)
        {
            // Empty table
            DataTable table = new();

            // Query string
            string query = "SELECT * FROM Request WHERE Request_Id LIKE '%" + keyword + "%' OR Hospital_Unit_Id LIKE '%" + keyword + "%' " +
                                         "Material_Name LIKE '%" + keyword + "%' OR Material_Quantity LIKE '%" + keyword + "%'";

            using(SqlDataAdapter adapter = new(query, connection))
            {
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    return JsonConvert.SerializeObject(table);
                }
                else
                {
                    return "No data found";
                }
            }
        }

        /// <summary>
        /// Post any amount of requests
        /// </summary>
        /// <param name="requests"></param>
        /// <returns>result string and code</returns>
        // POST api/requests/{"hospitalUnitId": #, "materialName": "###", "materialQuantity": # }
        [HttpPost]
        public ActionResult<string> Post([FromBody] IEnumerable<Request> requests)
        {
            try
            {
                // Failed inserts
                List<Request> fail = new();

                int rows;

                connection.Open();

                // Query command
                using SqlCommand command = new("INSERT INTO Request (Hospital_Unit_Id, Material_Name, Material_Quantity) " +
                                                "VALUES (@Unit, @Name, @Quantity)", connection);
                    
                // Iteration insert
                foreach (Request request in requests)
                {
                    command.Parameters.AddWithValue("@Unit", request.HospitalUnitId);
                    command.Parameters.AddWithValue("@Name", request.MaterialName);
                    command.Parameters.AddWithValue("@Quantity", request.MaterialQuantity);

                    rows = command.ExecuteNonQuery();

                    // If the query fails, adds to the list
                    if (rows == 0)
                    {
                        fail.Add(request);
                    }
                }
                if(fail.Count == 0)
                {
                    return "Requests made with success";
                }
                else
                {
                    return $"Requests made with success except: {fail}";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Deletes the Request from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Result</returns>
        // DELETE api/pacient/code
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            SqlCommand command = new("DELETE FROM Request WHERE Request_Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            int rows = command.ExecuteNonQuery();
            if (rows > 0)
            {
                return "Request deleted";
            }
            else
            {
                return "Failed";
            }
        }
    }
}
