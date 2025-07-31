using LMS.ApplicationCore.Entities.Common;
using LMS.ApplicationCore.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.ApplicationCore.Entities.Education
{
    public class Register : BaseEntity
    {

        public Guid TermCourseId { get; set; }
        [ForeignKey(nameof(TermCourseId))]
        public TermCourse? TermCourse { get; set; }


        public Guid StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public Student? Student { get; set; }

    }
}
