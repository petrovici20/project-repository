using PatientManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PatientManager.Services
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceContract]
    public interface IPatientRegistration
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patient"></param>
        /// <param name="hospitalUnit"></param>
        /// <returns></returns>
        [OperationContract]
        string AddPatient(Patient patient);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patients"></param>
        /// <returns></returns>
        [OperationContract]
        void AddPatientBulk(IEnumerable<Patient> patients);
    }
}
