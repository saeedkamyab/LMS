using LMS.Application.Dtos.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.ApplicationCore.Dtos.Identity
{
    public class PhoneNumberDto : BaseDto
    {
        public string Title { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;

        #region Relations
        public Guid PersonId { get; set; }
        [ForeignKey(nameof(PersonId))]
        public Person_DTO? Person { get; set; }
        #endregion
    }
}
