using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medic
{
    public class PatientCompanion
    {
        [Key]

        public int Age { get; set; }

        public int ID { get; set; }

        public Boolean Gender { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]

        public string LastName { get; set; }
        [Required]
        [StringLength(100)]

        public string Email { get; set; }
        [Required]
        [StringLength(100)]

        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string CellPhoneNumber { get; set; }

        public PatientCompanion() { }
    }
}
