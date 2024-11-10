using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pregledi.Models
{
    public class Hospital
    {
        public int Id { get; set; }

        public byte[] Image { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; } 

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}