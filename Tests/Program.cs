using ServiceReference;
using System;
using System.Collections.Generic;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            AddPatient();
            AddPatientBulk();
        }

        static async void AddPatient()
        {
            PatientRegistrationClient client = new();
            
            string result = await client.AddPatientAsync(new Patient
            {
                Utente = 123456789,
                Name = "admin",
                Age = new DateTime(2000, 10, 10),
                RNCCITypology = RNCCI.UC,
                Address = "ABC",
                Contact = 123456789,
                HospitalUnit = 101
            });
            

            Console.WriteLine(result);
            Console.ReadKey();

            client.Close();
        }

        static async void AddPatientBulk()
        {
            PatientRegistrationClient client = new();

            List<Patient> patients = new()
            {
                new Patient
                {
                    Utente = 1234,
                    Name = "admin",
                    Age = new DateTime(2000, 10, 10),
                    RNCCITypology = RNCCI.UC,
                    Address = "ABC",
                    Contact = 123456789,
                    HospitalUnit = 101
                },
                new Patient
                {
                    Utente = 4321,
                    Name = "admin",
                    Age = new DateTime(2000, 10, 10),
                    RNCCITypology = RNCCI.UC,
                    Address = "ABC",
                    Contact = 123456789,
                    HospitalUnit = 101
                },
            };

            string result = await client.AddPatientBulkAsync(patients);

            Console.WriteLine(result);

            client.Close();
        }
    }
}
