using LMS.ApplicationCore.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.ApplicationCore.Entities.Education
{
    [Table("Level",Schema ="Education")]
    public class Level : BaseEntity
    {
        [StringLength(130)]
        public string Title { get; set; } = string.Empty;
    }
}
