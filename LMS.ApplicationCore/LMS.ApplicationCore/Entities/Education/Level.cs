using LMS.ApplicationCore.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace LMS.ApplicationCore.Entities.Education
{
    public class Level : BaseEntity
    {
        [StringLength(130)]
        public string Title { get; set; } = string.Empty;
    }
}
