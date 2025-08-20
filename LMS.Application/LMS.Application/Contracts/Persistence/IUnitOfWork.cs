using LMS.Application.Contracts.Persistence.Common;
using LMS.ApplicationCore.Entities.Education;
using LMS.ApplicationCore.Entities.Finance;
using LMS.ApplicationCore.Entities.Identity;

namespace LMS.Application.Contracts.Persistence
{
    public interface IUnitOfWork
    {
        #region Identity
        IBaseRepository<Teacher> TeacherRepository { get; }
        IBaseRepository<Student> StudentRepository { get; }
        IBaseRepository<Employee> EmployeeRepository { get; }
        IBaseRepository<PhoneNumber> PhoneNumberRepository { get; }
        #endregion

        #region Education
        IBaseRepository<Level> LevelRepository { get; }
        IBaseRepository<Register> RegisterRepository { get; }
        IBaseRepository<TermCourse> TermCourseRepository { get; }
        IBaseRepository<TermCourseType> TermCourseTypeepository { get; }

        #endregion

        #region Finance
        IBaseRepository<PaymentTuition> PaymentTuitionRepository { get; }
        #endregion
        Task<int> CommitAsync();

    }
}