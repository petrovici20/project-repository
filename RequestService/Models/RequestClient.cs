using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestService.Models
{
    /// <summary>
    /// Copy of the class "Request" from the REST Service
    /// </summary>
    public class RequestClient
    {
        /// <summary>
        /// Request Id
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// Hospital Unit ID that needs the material
        /// </summary>
        public int HospitalUnitId { get; set; }

        /// <summary>
        /// Material Name
        /// </summary>
        public string MaterialName { get; set; }

        /// <summary>
        /// Material Qauntity
        /// </summary>
        public int MaterialQuantity { get; set; }
    }
}
