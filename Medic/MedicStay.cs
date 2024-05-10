using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medic
{
    public class MedicStay
    {
        [Key]
        public int ChildBearingAgeWoman { get; set; }
        public int ID { get; set; }

        public DateTime DateOfEntry { get; set; }

        public DateTime DateOfDischarge { get; set; }
        [Required]
        [StringLength(100)]

        public string MedicalRecord { get; set; }
        [Required]
        [StringLength(100)]

        public string TypeOfService { get; set; }
        [Required]
        [StringLength(100)]

        public string Origin { get; set; }
        [Required]
        [StringLength(100)]

        public string ReasonForDischarge { get; set; }
        [Required]
        [StringLength(100)]

        public string ConditionsTreated { get; set; }
        [Required]
        [StringLength(100)]

        public string Comorbidities { get; set; }
        [Required]
        [StringLength(100)]

        public string ExternalCause { get; set; }
        [Required]
        [StringLength(100)]

        public string HospitalAcquiredInfection { get; set; }
        public MedicStay() { }

    }
}
