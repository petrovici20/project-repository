using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitManager.Models
{
    /// <summary>
    /// Class that hold the model of information of each visit
    /// </summary>
    public class Visit
    {
        /// <summary>
        /// Utente of the patient of visit
        /// </summary>
        public int PatientUtente { get; set; }

        /// <summary>
        /// Name of the visitor
        /// </summary>
        public string VisitorName { get; set; }

        /// <summary>
        /// Time of arrival at the check-in
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// Time of departure at the check-out
        /// </summary>
        public DateTime DepartureTime { get; set; }
    }
}
