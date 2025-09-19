using FluentValidation;

namespace LMS.Application.Dtos.Education.Validations
{
    public class RegisterValidator : AbstractValidator<RegisterDto>
    {
        public RegisterValidator()
        {
            RuleFor(item => item.TuitionPayType)
                .NotEmpty().WithMessage("باید نوع پرداخت را انتخاب کنید")
                .NotNull().WithMessage("باید نوع پرداخت را انتخاب کنید") ;
            When(x => x.TuitionPayType == Constants.Enums.TuitionPayType.Installment, () =>
            {
                RuleFor(x => x.NumberOfInstallment)
                .GreaterThan(0).WithMessage("تعداد قسط ها باید بیشتر از صفر باشد")
                .NotEmpty().WithMessage("تعداد قسط ها باید بیشتر از صفر باشد");
            });
            RuleFor(item=>item.TermCourseId)
                .NotEmpty().WithMessage("انتخاب ترم/دوره ضروری می باشد")
                .NotNull().WithMessage("انتخاب ترم/دوره ضروری می باشد");
            RuleFor(item => item.TermCourse)
            .NotEmpty().WithMessage("انتخاب ترم/دوره ضروری می باشد")
            .NotNull().WithMessage("انتخاب ترم/دوره ضروری می باشد");

            RuleFor(item => item.StudentId)
    .NotEmpty().WithMessage("انتخاب زبان آموز ضروری می باشد")
    .NotNull().WithMessage("انتخاب زبان آموز ضروری می باشد");
            RuleFor(item => item.Student)
            .NotEmpty().WithMessage("انتخاب زبان آموز ضروری می باشد")
            .NotNull().WithMessage("انتخاب زبان آموز ضروری می باشد");
        }
    }
}
