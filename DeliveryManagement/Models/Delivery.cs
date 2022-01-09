using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryManagement.Models
{
    /// <summary>
    /// Class that has the cloned information of the request and it's confirmation
    /// </summary>
    public class Delivery
    {
        /// <summary>
        /// Request Id from the request
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// If the delivery is confirmed sent
        /// </summary>
        public string Delivered { get; set; }

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
