using LMS.Application.Dtos.Common;

namespace LMS.Application.Dtos.Education
{
    public class LevelDto : BaseDto
    {
        /// <summary>عنوان سطح</summary>
        public string Title { get; set; } = string.Empty;
    }
}
