using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medic
{
    public class PatientStatus
    {
        [Key]

        public int PatientNumber { get; set; }
        public int ID { get; set; }
        [Required]
        [StringLength(100)]

        public string PatientCode { get; set; }
        public PatientStatus() { }
    }
}
