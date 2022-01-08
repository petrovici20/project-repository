using PatientManager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PatientManager.Services
{
    public class PatientRegistration : IPatientRegistration
    {
        // Connection String
        readonly SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
        
        public string AddPatient(Patient patient)
        {
            try
            {
                #region SQL Commands
                // Get all utente numbers
                SqlCommand checkUtente = new SqlCommand("SELECT Utente FROM Patient", connection);

                // Get the amount of beds available in a hospital unit
                SqlCommand checkBeds = new SqlCommand("SELECT Beds_Available FROM Hospital_Unit WHERE Unit_Id = @Unit_Id", connection);
                checkBeds.Parameters.AddWithValue("@Unit_Id", patient.HospitalUnit);

                // Inserts the patient
                SqlCommand insertPatient = new SqlCommand("INSERT INTO Patient (Utente, Name, Age, Address, Contact, Unit_ID, RNCCI_Typology) " +
                                                          "VALUES (@Utente, @Name, @Age, @Address, @Contact, @Unit_Id, @RNCCI)", connection);
                insertPatient.Parameters.AddWithValue("@Utente", patient.Utente);
                insertPatient.Parameters.AddWithValue("@Name", patient.Name);
                insertPatient.Parameters.AddWithValue("@Age", patient.Age.ToString());
                insertPatient.Parameters.AddWithValue("@Address", patient.Address);
                insertPatient.Parameters.AddWithValue("@Contact", patient.Contact);
                insertPatient.Parameters.AddWithValue("@Unit_Id", patient.HospitalUnit);
                insertPatient.Parameters.AddWithValue("@RNCCI", patient.RNCCITypology);

                // Decrease by 1 the amount of beds in the hospital unit
                SqlCommand decreaseBeds = new SqlCommand("SELECT Beds_Available FROM Hospital_Unit WHERE Unit_Id = @Unit_Id", connection);

                #endregion

                connection.Open();

                // Returns if the Utente already is in the database
                using (SqlDataReader reader = checkUtente.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        if(patient.Utente == Convert.ToInt32(reader["Utente"].ToString()))
                        {
                            return "Utente taken";
                        }
                    }
                }

                // Returns if there is no beds available
                using (SqlDataReader reader = checkBeds.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int beds = Convert.ToInt32(reader["Beds_Available"].ToString());

                        if(beds == 0)
                        {
                            return "No beds available in this Unit";
                        }
                    }
                }

                // Inserts the patient in the database
                int rows = insertPatient.ExecuteNonQuery();

                if (rows > 0)
                {
                    // Decreases the number of beds in the database
                    rows = decreaseBeds.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        return "Patient Added";
                    }
                    else
                    {
                        return "Patient inserted but the beds did not decrease";
                    }
                }
                else return "Patient could not be added";
            }
            catch (Exception)
            {
                return "Some unknown error happend";
            }
            finally
            {
                connection.Close();
            }
        }

        public string AddPatientBulk(List<Patient> patients)
        {
            throw new NotImplementedException();
        }
    }
}
