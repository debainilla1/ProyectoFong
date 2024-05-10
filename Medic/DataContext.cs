using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medic
{
    public class DataContext : DbContext
    {
        public DbSet<AssignedMedic> AssignedMedics { get; set; }
        public DbSet<MedicStay> MedicStays { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientCompanion> PatientCompanions { get; set; }
        public DbSet<PatientStatus> PatientStatuses { get; set; }
        public DbSet<ActualizationPatient> ActualizationPatients { get; set; }


        public DataContext() : base("name=con") { }
    }
}