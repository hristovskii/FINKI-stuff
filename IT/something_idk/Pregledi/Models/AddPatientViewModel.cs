using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pregledi.Models
{
    public class AddPatientViewModel
    {
        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<Patient> Patients { get; set; }
        public int SelectedDoctorId { get; set; }
        public int SelectedPatientId { get; set; }
    }
}