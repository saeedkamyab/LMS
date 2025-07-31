using LMS.ApplicationCore.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.ApplicationCore.Entities.Education
{
    public class TermCourseType : BaseEntity
    {

        public Guid LevelId { get; set; }
        [ForeignKey(nameof(LevelId))]
        public Level? Level { get; set; }
    }
}
