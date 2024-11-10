using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_samostojno.Models
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string Address { get; set; }
        public virtual List<Doctor> Doctors { get; set; }

    }
}