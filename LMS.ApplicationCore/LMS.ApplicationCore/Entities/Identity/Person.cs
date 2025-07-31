using LMS.ApplicationCore.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace LMS.ApplicationCore.Entities.Identity
{
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

        public List<PhoneNumber>? PhoneNumbers { get; set; }
    }
}
