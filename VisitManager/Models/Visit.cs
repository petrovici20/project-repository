using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitManager.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Visit
    {
        /// <summary>
        /// 
        /// </summary>
        public int PatientUtente { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string VisitorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DepartureTime { get; set; }
    }
}
