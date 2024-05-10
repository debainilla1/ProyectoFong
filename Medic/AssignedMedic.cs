using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medic
{
    public class AssignedMedic
    {
        [Key]
        public int ProfessionalLicense { get; set; }
        public int ID { get; set; }
        [Required]
        [StringLength(100)]

        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]

        public string LastName { get; set; }

        public AssignedMedic() { }
    }
}
