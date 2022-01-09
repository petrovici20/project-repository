using PatientManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PatientManager.Services
{
    /// <summary>
    /// Interface of the Patient service
    /// </summary>
    [ServiceContract]
    public interface IPatientRegistration
    {
        /// <summary>
        /// Adds 1 patient in the database
        /// </summary>
        /// <param name="patient"></param>
        /// <param name="hospitalUnit"></param>
        /// <returns>result string</returns>
        [OperationContract]
        string AddPatient(Patient patient);

        /// <summary>
        /// Adds multiple patients in the database
        /// </summary>
        /// <param name="patients"></param>
        [OperationContract]
        void AddPatientBulk(IEnumerable<Patient> patients);

        /// <summary>
        /// Gets all the patients in the database
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetPatients();
    }
}
