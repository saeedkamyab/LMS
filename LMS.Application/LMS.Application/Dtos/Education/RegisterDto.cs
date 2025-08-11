using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity;

namespace LMS.Application.Dtos.Education
{
    public class RegisterDto : BaseDto
    {
        public byte TuitionPayType { get; set; }
        public int NumberOfInstallment { get; set; }
        public Guid TermCourseId { get; set; }
        public TermCourseDto? TermCourse { get; set; }

        public Guid StudentId { get; set; }
        public StudentDto? Student { get; set; }

    }
}
