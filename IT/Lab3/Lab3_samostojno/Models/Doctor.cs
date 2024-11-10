using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_samostojno.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsEmployed { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual List<Patient> Patients { get; set; }
    }
}