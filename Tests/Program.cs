using ServiceReference;
using System;

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

            client.Close();
        }

        static async void AddPatientBulk()
        {
            throw new NotImplementedException;
        }
    }
}
