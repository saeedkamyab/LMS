using AutoMapper;
using LMS.ApplicationCore.Dtos.Education;
using LMS.ApplicationCore.Dtos.Identity;
using LMS.ApplicationCore.Entities.Education;
using LMS.ApplicationCore.Entities.Finance;
using LMS.ApplicationCore.Entities.Identity;

namespace LMS.Application.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {

            #region  IdentityMapping
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Teacher, TeacherDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<PhoneNumber, PhoneNumberDto>().ReverseMap();
            #endregion

            #region  EducationMapping
            CreateMap<Level, LevelDto>().ReverseMap();
            CreateMap<Register, RegisterDto>().ReverseMap();
            CreateMap<TermCourse, TermCourseDto>().ReverseMap();
            CreateMap<TermCourseType, TermCourseTypeDto>().ReverseMap();
            #endregion


            #region  FinanceMapping
            CreateMap<PaymentTuitionDto, PaymentTuitionDto>().ReverseMap();
         
            #endregion

        }
    }
}
