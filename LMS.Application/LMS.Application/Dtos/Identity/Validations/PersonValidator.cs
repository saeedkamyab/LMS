using FluentValidation;

namespace LMS.Application.Dtos.Identity.Validations
{
    public class PersonValidator : AbstractValidator<PersonDto>
    {
        public PersonValidator()
        {

            RuleFor(item => item.FirstName)
             .NotEmpty().WithMessage("وارد کردن نام ضروری می باشد")
             .NotNull().WithMessage("وارد کردن نام  ضروری می باشد")
             .Length(130).WithMessage("نام نمیتواند بیش از 130 کاراکتر باشد");


            RuleFor(item => item.LastName)
 .NotEmpty().WithMessage("وارد کردن نام خانوادگی ضروری می باشد")
 .NotNull().WithMessage("وارد کردن نام خانوادگی  ضروری می باشد")
 .Length(130).WithMessage("نام خانوادگی نمیتواند بیش از 130 کاراکتر باشد");


            RuleFor(item => item.FatherName)
 .NotEmpty().WithMessage("وارد کردن نام پدر ضروری می باشد")
 .NotNull().WithMessage("وارد کردن نام پدر  ضروری می باشد")
 .Length(130).WithMessage("نام پدر نمیتواند بیش از 130 کاراکتر باشد");


            RuleFor(item => item.NationalCode)
.Length(10).WithMessage("کدملی نمیتواند بیش از 10 رقم باشد");

            RuleFor(item => item.BrithDate)
              .NotEmpty().WithMessage("تاریخ تولد را انتخاب کنید")
              .NotNull().WithMessage("تاریخ تولد را انتخاب کنید");


            RuleFor(item => item.Address)
.Length(300).WithMessage("آدرس نمیتواند بیش از 300 کاراکتر باشد");


            When(x => x.IsActive == true, () =>
            {
                RuleFor(x => x.UserName)
                 .NotEmpty().WithMessage("نام کاربری نمیتواند خالی باشد")
              .NotNull().WithMessage("نام کاربری نمیتواند خالی باشد")
                .Length(150).WithMessage("عنوان نمیتواند بیش از 150 کاراکتر باشد");

                RuleFor(x => x.Password)
      .NotEmpty().WithMessage("گذرواژه نمیتواند خالی باشد")
   .NotNull().WithMessage("گذرواژه نمیتواند خالی باشد")
     .Length(150).WithMessage("گذرواژه نمیتواند بیش از 150 کاراکتر باشد");
            });
        }
    }
}
