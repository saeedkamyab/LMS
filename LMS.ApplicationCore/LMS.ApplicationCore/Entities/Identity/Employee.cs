using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.ApplicationCore.Entities.Identity
{
    [Table("Employee", Schema = "Identity")]
    public class Employee:Person
    {
    }
}
