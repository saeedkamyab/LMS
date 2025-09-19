using FluentValidation;

namespace LMS.Application.Dtos.Education.Validations
{
    public class TermCourseTypeValidator : AbstractValidator<TermCourseTypeDto>
    {
        public TermCourseTypeValidator()
        {

            RuleFor(item => item.ClassType)
             .NotEmpty().WithMessage("باید نوع  را انتخاب کنید")
             .NotNull().WithMessage("باید نوع  را انتخاب کنید");

            RuleFor(item => item.Amount)
             .NotEmpty().WithMessage("وارد کردن مبلغ ترم / دوره ضروری می باشد")
             .NotNull().WithMessage("وارد کردن مبلغ ترم / دوره ضروری می باشد");


       
            RuleFor(item => item.LevelId)
                .NotEmpty().WithMessage("انتخاب سطح ضروری می باشد")
                .NotNull().WithMessage("انتخاب سطح ضروری می باشد");
            RuleFor(item => item.Level)
            .NotEmpty().WithMessage("انتخاب سطح ضروری می باشد")
            .NotNull().WithMessage("انتخاب سطح ضروری می باشد");

         
        }
    }
}
