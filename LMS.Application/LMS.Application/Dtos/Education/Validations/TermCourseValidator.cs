using FluentValidation;

namespace LMS.Application.Dtos.Education.Validations
{
    public class TermCourseValidator : AbstractValidator<TermCourseDto>
    {
        public TermCourseValidator()
        {
            RuleFor(item => item.Title)
             .NotEmpty().WithMessage("وارد کردن عنوان ضروری می باشد")
             .NotNull().WithMessage("وارد کردن عنوان ضروری می باشد")
             .Length(130).WithMessage("عنوان نمیتواند بیش از 130 کاراکتر باشد");


            RuleFor(item => item.StartTime)
                .NotEmpty().WithMessage("ساعت شروع را انتخاب نمایید")
                .NotNull().WithMessage("ساعت شروع را انتخاب نمایید");

            RuleFor(item => item.EndTime)
                .NotEmpty().WithMessage("ساعت پایان را انتخاب نمایید")
                .NotNull().WithMessage("ساعت پایان را انتخاب نمایید");

            RuleFor(item => item.Days)
            .NotEmpty().WithMessage("روزهای برگذاری را انتخاب نمایید")
            .NotNull().WithMessage("روزهای برگذاری را انتخاب نمایید");

            RuleFor(item => item.StartDate)
            .NotEmpty().WithMessage("تاریخ آغاز ترم/دوره ضروری می باشد")
            .NotNull().WithMessage("تاریخ آغاز ترم/دوره ضروری می باشد");

            RuleFor(item => item.EndDate)
             .NotEmpty().WithMessage("تاریخ پایان ترم/دوره ضروری می باشد")
             .NotNull().WithMessage("تاریخ پایان ترم/دوره ضروری می باشد");

            RuleFor(item => item)
             .Must(item => item.StartDate < item.EndDate)
             .NotEmpty().WithMessage("تاریخ آغاز باید کوچک تر از تاریخ پایان ترم/دوره باشد")
             .NotNull().WithMessage("تاریخ آغاز باید کوچک تر از تاریخ پایان ترم/دوره باشد");


            RuleFor(item => item.TeacherId)
                .NotEmpty().WithMessage("انتخاب مدرس ضروری می باشد")
                .NotNull().WithMessage("انتخاب مدرس ضروری می باشد");
            RuleFor(item => item.Teacher)
            .NotEmpty().WithMessage("انتخاب مدرس ضروری می باشد")
            .NotNull().WithMessage("انتخاب مدرس ضروری می باشد");

            RuleFor(item => item.TermCourseTypeId)
             .NotEmpty().WithMessage("انتخاب نوع ترم/دوره ضروری می باشد")
             .NotNull().WithMessage("انتخاب نوع ترم/دوره ضروری می باشد");
            RuleFor(item => item.TermCourseType)
            .NotEmpty().WithMessage("انتخاب نوع ترم/دوره ضروری می باشد")
            .NotNull().WithMessage("انتخاب نوع ترم/دوره ضروری می باشد");
        }
    }
}
