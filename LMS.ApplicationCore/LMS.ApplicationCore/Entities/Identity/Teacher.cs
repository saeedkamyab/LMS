using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.ApplicationCore.Entities.Identity
{
    [Table("Teacher", Schema = "Identity")]
    public class Teacher : Person
    {
    }
}
