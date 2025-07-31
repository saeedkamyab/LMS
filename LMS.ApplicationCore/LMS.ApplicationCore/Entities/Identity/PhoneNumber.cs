using LMS.ApplicationCore.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.ApplicationCore.Entities.Identity
{
    public class PhoneNumber : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;

        #region Relations
        public Guid PersonId { get; set; }
        [ForeignKey(nameof(PersonId))]
        public Person? Person { get; set; }
        #endregion
    }
}
