using DeliveryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

    
namespace DeliveryManagement.Controllers
{
    /// <summary>
    /// REST Controller for the CRUD methods
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        // Connection String
        readonly SqlConnection connection = new(@"Data Source=.;Initial Catalog=Central_Compras_Estado;Integrated Security=True");

        /// <summary>
        /// Gets the deliveries from the database
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
                    using(SqlDataAdapter adapter = new(command))
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
        /// Gets the deliveries from the database with a specific keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns>Json string with deliveries</returns>
        // GET api/deliveries/###
        [HttpGet("{keyword}")]
        public string Get(string keyword)
        {
            // Empty table
            DataTable table = new();

            // Query string
            string query = "SELECT * FROM Delivery WHERE Request_Id LIKE '%" + keyword + "%' OR Hospital_Unit_Id LIKE '%" + keyword + "%' " +
                                         "Material_Name LIKE '%" + keyword + "%' OR Material_Quantity LIKE '%" + keyword + "%'";

            using (SqlDataAdapter adapter = new(query, connection))
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
        /// Post any amount of Deliveries
        /// </summary>
        /// <param name="deliveries"></param>
        /// <returns>result string and code</returns>
        // POST api/deliveries/{"requestId": #, "hospitalUnitId": #, "materialName": "###", "materialQuantity": #, "delivered": "###" }
        [HttpPost]
        public ActionResult<string> Post([FromBody] IEnumerable<Delivery> deliveries)
        {
            try
            {
                // Failed inserts
                List<Delivery> fail = new();

                int rows;

                connection.Open();

                // Query command
                using SqlCommand command = new("INSERT INTO Delivery (Request_Id, Hospital_Unit_Id, Material_Name, Material_Quantity, Delivered) " +
                                                "VALUES (@Request, @Unit, @Name, @Quantity, @Delivered)", connection);

                // Iteration insert
                foreach (Delivery delivery in deliveries)
                {
                    command.Parameters.AddWithValue("@Request", delivery.RequestId);
                    command.Parameters.AddWithValue("@Unit", delivery.HospitalUnitId);
                    command.Parameters.AddWithValue("@Name", delivery.MaterialName);
                    command.Parameters.AddWithValue("@Quantity", delivery.MaterialQuantity);
                    command.Parameters.AddWithValue("@Delivered", "No");

                    rows = command.ExecuteNonQuery();

                    // If the query fails, adds to the list
                    if (rows == 0)
                    {
                        fail.Add(delivery);
                    }
                }
                if (fail.Count == 0)
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
