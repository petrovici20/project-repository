using PatientReferenceSync;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PatientService
{
    /// <summary>
    /// Makes the connection to the SOAP "Patient" Service
    /// </summary>
    public class PatientConnection
    {
        /// <summary>
        /// Calls the method that gets all the patients
        /// </summary>
        /// <returns>patients table</returns>
        public static string GetPatients()
        {
            PatientRegistrationClient client = new();

            string result = client.GetPatients();

            client.Close();

            return result;
        }

        /// <summary>
        /// Calls the method that adds a patient
        /// </summary>
        /// <returns>result string</returns>
        public static string AddPatient(Patient patient)
        {
            PatientRegistrationClient client = new();

            string result = client.AddPatient(new Patient
            {
                Name = patient.Name,
                Utente = patient.Utente,
                Age = patient.Age,
                RNCCITypology = patient.RNCCITypology,
                Address = patient.Address,
                Contact = patient.Contact,
                HospitalUnit = patient.HospitalUnit
            });

            client.Close();

            return result;
        }
    }
}
