using Microsoft.AspNetCore.Mvc;
using SupplyManager.Models;
using System;
using System.Collections.Generic;
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
        readonly string connectionString = @"Data Source=.;Initial Catalog=Central_Compras_Estado;Integrated Security=True";

        /// <summary>
        /// Post any amount of requests
        /// </summary>
        /// <param name="requests"></param>
        /// <returns>result string and code</returns>
        // POST api/{"hospitalUnitId": #, "materialName": "###", "materialQuantity": # }
        [HttpPost]
        public ActionResult<string> Post([FromBody] IEnumerable<Request> requests)
        {
            try
            {
                // Failed inserts
                List<Request> fail = new();

                // Start disposable connection
                using(SqlConnection connection = new(connectionString))
                {
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
    }
}
