using Pregledi.Models;
using System.Data.Entity;

namespace Pregledi.Context
{
    public class PreglediContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Hospital> Hospitals { get; set;}
    }
}