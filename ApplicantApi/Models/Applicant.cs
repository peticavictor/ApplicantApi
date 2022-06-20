using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicantApi.Models
{
    public class Applicant
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Surname { get; set; }
        [Required]
        public String Email{ get; set; }
        public String PhoneNumber { get; set; }
        public String City{ get; set; }
        public String School{ get; set; }
        public String Certifications{ get; set; }
        public String Skills{ get; set; }
        public String JobTitle{ get; set; }
        public String EmploymentHistory{ get; set; }
        public int Salary{ get; set; }
    }
}
