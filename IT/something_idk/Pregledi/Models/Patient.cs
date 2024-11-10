using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pregledi.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Patient Name is required")]
        [Display(Name = "Patient Name")]
        public string Name { get; set; }

        [Required]
        public Genders Gender { get; set; }

        [Required(ErrorMessage = "Patient Code is required")]
        [Display(Name="Code of the Patient")]
        [Range(10000, 99999, ErrorMessage = "Patient Code must be exactly 5 digits")]
        public int PatientCode { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}