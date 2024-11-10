using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pregledi.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public virtual Hospital Hospital { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}