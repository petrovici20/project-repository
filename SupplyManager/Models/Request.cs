using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyManager.Models
{
    /// <summary>
    /// Class that holds the required information for a request
    /// </summary>
    public class Request
    {
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
