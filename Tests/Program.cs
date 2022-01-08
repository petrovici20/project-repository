using ServiceReference;
using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            AddPacient();
        }

        static async void AddPacient()
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
    }
}
