using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManage.DBContext
{
    public class PersonModel
    {
        [Key]
        public int PersonId { get; set; }

        [Column("FirstName", TypeName = "nvarchar(128)")]
        public string firstName { get; set; }

        [Column("LastName", TypeName = "nvarchar(128)")]
        public string lastName { get; set; }

        [Column("BirthDate")]
        public DateTime birthDate { get; set; }

        ICollection<EmployeeModel> employeeModels { get; set; }
    }
}
