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
        public string FullName { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string CompanyName { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string MobileNo { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string EmailId { get; set; }

    }
}
