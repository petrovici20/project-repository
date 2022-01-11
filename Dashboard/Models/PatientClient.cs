using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Models
{
    public class PatientClient
    {
        [Key]
        public int Utente { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Age { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int Contact { get; set; }

        [Required]
        public int HospitalUnit { get; set; }

        [Required]
        public string RNCCITypology { get; set; }
    }
}
