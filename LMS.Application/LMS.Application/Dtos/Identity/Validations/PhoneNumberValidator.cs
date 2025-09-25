using FluentValidation;

namespace LMS.Application.Dtos.Identity.Validations
{
    public class PhoneNumberValidator : AbstractValidator<PhoneNumberDto>
    {
        public PhoneNumberValidator()
        {

            RuleFor(item => item.Title)
             .NotEmpty().WithMessage("وارد کردن عنوان ضروری می باشد")
             .NotNull().WithMessage("وارد کردن عنوان  ضروری می باشد")
             .Length(130).WithMessage("عنوان نمیتواند بیش از 130 کاراکتر باشد");


            RuleFor(item => item.Number)
 .NotEmpty().WithMessage("وارد کردن شماره تلفن ضروری می باشد")
 .NotNull().WithMessage("وارد کردن شماره تلفن  ضروری می باشد")
 .Length(130).WithMessage("شماره تلفن نمیتواند بیش از 130 کاراکتر باشد");


            RuleFor(item => item.PersonId)
      .NotEmpty().WithMessage("انتخاب شخص ضروری می باشد")
      .NotNull().WithMessage("انتخاب شخص ضروری می باشد");
            RuleFor(item => item.Person)
            .NotEmpty().WithMessage("انتخاب شخص ضروری می باشد")
            .NotNull().WithMessage("انتخاب شخص ضروری می باشد");
        }
    }
}
