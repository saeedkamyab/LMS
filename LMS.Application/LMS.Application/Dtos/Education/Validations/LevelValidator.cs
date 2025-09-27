using FluentValidation;

namespace LMS.Application.Dtos.Education.Validations
{
    public class LevelValidator: AbstractValidator<LevelDto>
    {
        public LevelValidator()
        {
            RuleFor(item => item.Title)
                .NotEmpty().WithMessage("وارد کردن عنوان ضروری می باشد")
                .NotNull().WithMessage("وارد کردن عنوان  ضروری می باشد")
                .MaximumLength(130).WithMessage("عنوان نمیتواند بیش از 130 کاراکتر باشد");
        }
    }
}
