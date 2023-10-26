using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManage.DBContext
{
    public class EmployeeModel
    { 
        [Key]
        public int EmployeeId { get; set; }

        [Column("EmployeeNum", TypeName = "nvarchar(16)")]
        public string EmployeeNum { get; set; }

        [Column("EmployeeDate")]
        public DateTime EmployeeDate { get; set; }

        [Column("Terminated")]
        public DateTime Terminated { get; set; }

        public PersonModel Person { get; set; }
    }
}
