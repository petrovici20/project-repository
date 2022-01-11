using PatientReferenceSync;
using PatientService;
using System;
using System.Data;
using VisitService;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            // PatientTest();
            // VisitTest();
        }

        static void PatientTest()
        {
            Console.WriteLine(PatientConnection.AddPatient(new Patient { 
                Name = "admin" ,
                Utente = 9999,
                Age = DateTime.Now,
                RNCCITypology = (RNCCI)Enum.Parse(typeof(RNCCI), "UC"),
                Address = "RUA T",
                Contact = 9999,
                HospitalUnit = 101
            }));

            Console.WriteLine(PatientConnection.GetPatients());
            Console.ReadKey();
        }
        static void VisitTest()
        {
            Console.WriteLine(VisitConnection.GetVisits());
            Console.ReadKey();
        }
    }
}