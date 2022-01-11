using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitService.Models
{
    /// <summary>
    /// Copy of the class "Visit" from the REST Service
    /// </summary>
    public class VisitClient
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
