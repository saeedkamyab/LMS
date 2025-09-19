using LMS.Application.Constants.Enums;
using LMS.Application.Dtos.Common;

namespace LMS.Application.Dtos.Education
{
    public class TermCourseTypeDto : BaseDto
    {
        public ClassType ClassType { get; set; }
        public decimal Amount { get; set; }

        #region Relations
        public Guid LevelId { get; set; }
        public LevelDto? Level { get; set; }
        public List<TermCourseDto>? TermCourses { get; set; }
        #endregion
    }
}
