using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pregledi.Models
{
    public class SelectHospitalViewModel
    {
        public Doctor Doctor { get; set; }
        public IEnumerable<Hospital> Hospitals { get; set; }
        public int SelectedHospitalId { get; set; }
    }
}