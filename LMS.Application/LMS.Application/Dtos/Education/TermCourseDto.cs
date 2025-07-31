using LMS.Application.Dtos.Common;
using LMS.ApplicationCore.Dtos.Identity;

namespace LMS.ApplicationCore.Dtos.Education
{
    public class TermCourseDto: BaseDto
    {
        public string Title { get; set; } = string.Empty;
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Days { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        #region Relations
        public Guid TeacherId { get; set; }
        public TeacherDto? Teacher { get; set; }
        
        public Guid TermCourseTypeId { get; set; }
        public TermCourseTypeDto? TermCourseType { get; set; }
        #endregion
    }
}
