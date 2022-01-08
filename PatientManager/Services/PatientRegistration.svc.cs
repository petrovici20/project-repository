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
        readonly string connectionString = @"Data Source=.;Initial Catalog=Hospital;Integrated Security=True";
        
        public string AddPatient(Patient patient)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    #region SQL Commands

                    // Get all utente numbers
                    SqlCommand checkUtente = new SqlCommand("SELECT Utente FROM Patient", connection);

                    // Get the amount of beds available in a hospital unit
                    SqlCommand checkBeds = new SqlCommand("SELECT Beds_Available FROM Hospital_Unit WHERE Unit_Id = @Unit_Id", connection);
                    checkBeds.Parameters.AddWithValue("@Unit_Id", patient.HospitalUnit);

                    // Get the hospital unit id
                    SqlCommand checkUnit = new SqlCommand("SELECT Unit_Id FROM Hospital_Unit", connection);

                    // Adds the patient
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
                    SqlCommand decreaseBeds = new SqlCommand("UPDATE Hospital_Unit SET Beds_Available = Beds_Available - 1 WHERE Unit_Id = @Unit_Id", connection);
                    decreaseBeds.Parameters.AddWithValue("@Unit_Id", patient.HospitalUnit);

                    #endregion


                    if(patient.RNCCITypology != Tools.RNCCI.EDCCI)
                    {
                        // Returns if the Hospital Unit is invalid
                        using (SqlDataReader reader = checkUnit.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (patient.HospitalUnit != Convert.ToInt32(reader["Unit_Id"].ToString()))
                                {
                                    return $"Invalid Hospital Unit Id: {patient.HospitalUnit}";
                                }
                            }
                        }
                    }

                    // Returns if the Utente already is in the database
                    using (SqlDataReader reader = checkUtente.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (patient.Utente == Convert.ToInt32(reader["Utente"].ToString()))
                            {
                                return $"Utente {patient.Utente} taken";
                            }
                            
                        }
                    }

                    // Returns if there is no beds available
                    using (SqlDataReader reader = checkBeds.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int beds = Convert.ToInt32(reader["Beds_Available"].ToString());

                            if (beds == 0)
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
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddPatientBulk(IEnumerable<Patient> patients)
        {
            try
            {
                const string queryPatient = @"INSERT INTO Patient (Utente, Name, Age, Address, Contact, Unit_ID, RNCCI_Typology) " +
                                      "VALUES (@Utente, @Name, @Age, @Address, @Contact, @Unit_Id, @RNCCI)";

                const string queryBed = @"SELECT Beds_Available FROM Hospital_Unit WHERE Unit_Id = @Unit_Id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand insertPatient = new SqlCommand(queryPatient, connection))
                    {
                        foreach (Patient patient in patients)
                        {
                            insertPatient.Parameters.AddWithValue("@Utente", patient.Utente);
                            insertPatient.Parameters.AddWithValue("@Name", patient.Name);
                            insertPatient.Parameters.AddWithValue("@Age", patient.Age.ToString());
                            insertPatient.Parameters.AddWithValue("@Address", patient.Address);
                            insertPatient.Parameters.AddWithValue("@Contact", patient.Contact);
                            insertPatient.Parameters.AddWithValue("@Unit_Id", patient.HospitalUnit);
                            insertPatient.Parameters.AddWithValue("@RNCCI", patient.RNCCITypology);

                            insertPatient.ExecuteNonQuery();
                            
                            using (SqlCommand decreaseBeds = new SqlCommand(queryBed, connection))
                            {
                                decreaseBeds.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
