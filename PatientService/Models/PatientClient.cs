using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientService.Models
{
    /// <summary>
    /// Copy of the class "Patient" from the REST Service
    /// </summary>
    public class PatientClient
    {
        /// <summary>
        /// Utente of the patient
        /// </summary>
        public int Utente { get; set; }

        /// <summary>
        /// Name of the patient
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Birth date of the patient
        /// </summary>
        public DateTime Age { get; set; }

        /// <summary>
        /// Address of the patient
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Contact of the patient
        /// </summary>
        public int Contact { get; set; }

        /// <summary>
        /// Hospital unit in which the patient is designated
        /// </summary>
        public int HospitalUnit { get; set; }

        /// <summary>
        /// RNCCI Typology in which the patient is designated
        /// </summary>
        public string RNCCITypology { get; set; }
    }
}
