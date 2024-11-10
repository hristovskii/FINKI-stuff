using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_samostojno.Models
{
    public class DoctorPatient
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public List<Patient> Patients { get; set; }
        public DoctorPatient() 
        { 
            Patients = new List<Patient>();
        }
    }
}