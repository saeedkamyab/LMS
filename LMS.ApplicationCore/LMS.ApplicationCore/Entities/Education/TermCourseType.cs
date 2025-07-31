using LMS.ApplicationCore.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.ApplicationCore.Entities.Education
{
    public class TermCourseType : BaseEntity
    {
        public byte ClassType { get; set; }
        public decimal Amount { get; set; }

        #region Relations
        public Guid LevelId { get; set; }
        [ForeignKey(nameof(LevelId))]
        public Level? Level { get; set; }
        public List<TermCourse>? TermCourses { get; set; }
        #endregion
    }
}
