using LMS.Application.Contracts.Persistence;
using LMS.Application.Contracts.Persistence.Common;
using LMS.ApplicationCore.Entities.Education;
using LMS.ApplicationCore.Entities.Finance;
using LMS.ApplicationCore.Entities.Identity;
using LMS.Persistence.Repositories.Common;

namespace LMS.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LMSDbContext _context;

        public UnitOfWork(LMSDbContext context)
        {
            _context = context;
        }
        private IBaseRepository<Level>? _levelRepository;
        public IBaseRepository<Level> LevelRepository
            => _levelRepository ??= new BaseRepository<Level>(_context);

        public IBaseRepository<Teacher> TeacherRepository => throw new NotImplementedException();

        public IBaseRepository<Student> StudentRepository => throw new NotImplementedException();

        public IBaseRepository<Employee> EmployeeRepository => throw new NotImplementedException();

        public IBaseRepository<PhoneNumber> PhoneNumberRepository => throw new NotImplementedException();

        public IBaseRepository<Register> RegisterRepository => throw new NotImplementedException();

        public IBaseRepository<TermCourse> TermCourseRepository => throw new NotImplementedException();

        public IBaseRepository<TermCourseType> TermCourseTypeepository => throw new NotImplementedException();

        public IBaseRepository<PaymentTuitionDto> PaymentTuitionRepository => throw new NotImplementedException();

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
