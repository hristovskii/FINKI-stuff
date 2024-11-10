using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3_samostojno.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Range(10000, 99999, ErrorMessage = " only 5 digits")]
        [Display(Name = "Kod na pacient")]
        public int PatientCode { get; set; }
        public string Gender { get; set; }
        public virtual List<Doctor> Doctors { get; set; }
    }
}