using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_samostojno.Models
{
    public class PatientGenders
    {
        public int PatientId { get; set; }
        public string SelectedGender { get; set; }
        public Patient Patient { get; set; }
        public List<string> Genders { get; set; } = new List<string>()
        {
            "Male", "Female"
        };
    }
}