using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseNo._2.Model
{
    public class PersonModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string MobileNo { get; set; }

    }
}
