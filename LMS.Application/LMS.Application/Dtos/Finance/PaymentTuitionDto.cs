using LMS.ApplicationCore.Entities.Common;
using LMS.ApplicationCore.Entities.Education;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.ApplicationCore.Entities.Finance
{
    public class PaymentTuitionDto : BaseEntity
    {
        public DateTime PayDate { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaied { get; set; }

        #region Relations
        public Guid RegisterId { get; set; }
        [ForeignKey(nameof(RegisterId))]
        public Register? Register { get; set; }
        #endregion
    }
}
