using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpRegister.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Code")]
        public string EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Position")]
        public string Position { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [Column(TypeName = "varchar(20)")]
        [DisplayName("Mobile No")]
        public string MobileNo { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Email Id")]
        public string EmailId { get; set; }

    }
}
