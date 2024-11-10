using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_samostojno.Models
{
    public class HospitalDoctor
    {
        public int HospitalId { get; set; }
        public int DoctorId { get; set; }
        public List<Doctor> Doctors { get; set; }
        public HospitalDoctor()
        {
            Doctors = new List<Doctor>();
        }
    }
}