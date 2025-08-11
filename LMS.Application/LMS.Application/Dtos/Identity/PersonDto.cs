using LMS.Application.Dtos.Common;
using System.ComponentModel.DataAnnotations;

namespace LMS.Application.Dtos.Identity
{
    public class PersonDto : BaseDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string? NationalCode { get; set; }
        public DateTime BrithDate { get; set; }
        public string? Address { get; set; }

        public List<PhoneNumberDto>? PhoneNumbers { get; set; }
    }
}
