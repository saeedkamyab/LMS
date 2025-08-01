using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.ApplicationCore.Entities.Identity
{
    [Table("Student", Schema = "Identity")]
    public class Student:Person
    {
    }
}
