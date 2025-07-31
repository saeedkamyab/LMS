using LMS.ApplicationCore.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.ApplicationCore.Entities.Education
{
    public class Level : BaseEntity
    {
        [StringLength(130)]
        public string Title { get; set; } = string.Empty;
    }
}
