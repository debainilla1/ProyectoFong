using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medic
{
    public class Patient
    {
        [Key]

        public int SocialSecuritynumber { get; set; }
        public int ID { get; set; }

        public int MaritalStatus { get; set; }

        public int Weight { get; set; }

        public int ZipCode { get; set; }

        public int PhoneNumber { get; set; }

        public Boolean Gender { get; set; }

        public DateTime BirthDate { get; set; }
        [Required]
        [StringLength(100)]

        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]

        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        public string Curp { get; set; }
        [Required]
        [StringLength(100)]

        public string BirthPlace { get; set; }
        [Required]
        [StringLength(100)]

        public string Address { get; set; }
        [Required]
        [StringLength(100)]

        public string Country { get; set; }
        [Required]
        [StringLength(100)]

        public string State { get; set; }
        [Required]
        [StringLength(100)]

        public string Municipality { get; set; }
        public Patient() { }
    }
}