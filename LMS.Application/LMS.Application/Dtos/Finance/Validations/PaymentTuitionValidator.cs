using FluentValidation;
using LMS.Application.Dtos.Finance;

namespace LMS.Application.Dtos.Finance.Validations
{
    public class PaymentTuitionValidator : AbstractValidator<PaymentTuitionDto>
    {
        public PaymentTuitionValidator()
        {
            RuleFor(item => item.PayDate)
                .NotEmpty().WithMessage("تاریخ پرداخت را انتخاب کنید")
                .NotNull().WithMessage("تاریخ پرداخت را انتخاب کنید") ;
       
            RuleFor(item=>item.Amount)
                .NotEmpty().WithMessage("وارد کردن مبلغ ضروری می باشد")
                .NotNull().WithMessage("وارد کردن مبلغ ضروری می باشد");

            RuleFor(item => item.RegisterId)
    .NotEmpty().WithMessage("انتخاب آیتم ضروری می باشد")
    .NotNull().WithMessage("انتخاب آیتم ضروری می باشد");
            RuleFor(item => item.Register)
            .NotEmpty().WithMessage("انتخاب آیتم ضروری می باشد")
            .NotNull().WithMessage("انتخاب آیتم ضروری می باشد");
        }
    }
}
