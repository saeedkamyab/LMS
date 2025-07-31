using LMS.ApplicationCore.Entities.Common;
using LMS.ApplicationCore.Entities.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.ApplicationCore.Entities.Education
{
    public class TermCourse:BaseEntity
    {
        [StringLength(130)]
        public string Title { get; set; } = string.Empty;
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Days { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        #region Relations
        public Guid TeacherId { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public Teacher? Teacher { get; set; }
        
        public Guid TermCourseTypeId { get; set; }
        [ForeignKey(nameof(TermCourseTypeId))]
        public TermCourseType? TermCourseType { get; set; }
        #endregion
    }
}
