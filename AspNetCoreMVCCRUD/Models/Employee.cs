using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreMVCCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Emp Code")]
        public string EmpCode { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Position { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
