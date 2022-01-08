using PatientManager.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PatientManager.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Utente of the patient
        /// </summary>
        [DataMember]
        public int Utente { get; set; }

        /// <summary>
        /// Name of the patient
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Birth date of the patient
        /// </summary>
        [DataMember]
        public DateTime Age { get; set; }

        /// <summary>
        /// Address of the patient
        /// </summary>
        [DataMember]
        public string Address { get; set; }

        /// <summary>
        /// Contact of the patient
        /// </summary>
        [DataMember]
        public int Contact { get; set; }

        /// <summary>
        /// Hospital unit in which the patient is designated
        /// </summary>
        [DataMember]
        public int HospitalUnit { get; set; }

        /// <summary>
        /// RNCCI Typology in which the patient is designated
        /// </summary>
        [DataMember]
        public RNCCI RNCCITypology { get; set; }
    }
}