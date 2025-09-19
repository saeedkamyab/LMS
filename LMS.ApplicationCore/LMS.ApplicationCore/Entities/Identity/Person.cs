using LMS.ApplicationCore.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security;

namespace LMS.ApplicationCore.Entities.Identity
{
    [Table("Person", Schema = "Identity")]
    public class Person : BaseEntity
    {
        [StringLength(130)]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(130)]
        public string LastName { get; set; } = string.Empty;
        [StringLength(130)]
        public string FatherName { get; set; } = string.Empty;
        [StringLength(10)]
        public string? NationalCode { get; set; }
        public DateTime BrithDate { get; set; }
        [StringLength(300)]
        public string? Address { get; set; }
        [StringLength(150)]
        public string? UserName { get; set; }
        [StringLength(150)]
        public string? Password { get; set; }
        public bool IsActive { get; set; }

        public List<PhoneNumber>? PhoneNumbers { get; set; }
    }
}
