using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWork.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        [Column("empName",TypeName ="varchar(100)")]
      public  string Name { get; set; }
       public int Age { get; set; }
      public  string Gender { get; set; }

    }
}
