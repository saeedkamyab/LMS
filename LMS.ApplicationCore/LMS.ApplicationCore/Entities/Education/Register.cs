using LMS.ApplicationCore.Entities.Common;
using LMS.ApplicationCore.Entities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.ApplicationCore.Entities.Education
{
    public class Register : BaseEntity
    {
        public byte TuitionPayType { get; set; }
        public int NumberOfInstallment { get; set; }
        public Guid TermCourseId { get; set; }
        [ForeignKey(nameof(TermCourseId))]
        public TermCourse? TermCourse { get; set; }


        public Guid StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public Student? Student { get; set; }

    }
}
