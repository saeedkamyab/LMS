using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Application.Dtos.Finance
{
    public class PaymentTuitionDto : BaseDto
    {
        public DateTime PayDate { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaied { get; set; }

        #region Relations
        public Guid RegisterId { get; set; }
        [ForeignKey(nameof(RegisterId))]
        public RegisterDto? Register { get; set; }
        #endregion
    }
}
