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
        private IBaseRepository<Level>? _levelRepository;
        private IBaseRepository<Student>? _studentRepository;
        private IBaseRepository<Employee>? _employeeRepository;
        private IBaseRepository<PhoneNumber>? _phoneNumberRepository;
        private IBaseRepository<Register>? _registerRepository;
        private IBaseRepository<TermCourse>? _termCourseRepository;
        private IBaseRepository<TermCourseType>? _termCourseTypeRepository;
        private IBaseRepository<PaymentTuition>? _paymentTuitionRepository;

        public UnitOfWork(LMSDbContext context)
        {
            _context = context;
        }

        public IBaseRepository<Level> LevelRepository
            => _levelRepository ??= new BaseRepository<Level>(_context);

        public IBaseRepository<Teacher> TeacherRepository
            => throw new NotImplementedException();

        public IBaseRepository<Student> StudentRepository 
            => _studentRepository ??= new BaseRepository<Student>(_context);

        public IBaseRepository<Employee> EmployeeRepository 
            => _employeeRepository ??= new BaseRepository<Employee>(_context);

        public IBaseRepository<PhoneNumber> PhoneNumberRepository 
            => _phoneNumberRepository ??= new BaseRepository<PhoneNumber>(_context);

        public IBaseRepository<Register> RegisterRepository
            => _registerRepository ??= new BaseRepository<Register>(_context);

        public IBaseRepository<TermCourse> TermCourseRepository 
            => _termCourseRepository ??= new BaseRepository<TermCourse>(_context);

        public IBaseRepository<TermCourseType> TermCourseTypeepository
            => _termCourseTypeRepository ??= new BaseRepository<TermCourseType>(_context);

        public IBaseRepository<PaymentTuition> PaymentTuitionRepository 
            => _paymentTuitionRepository ??= new BaseRepository<PaymentTuition>(_context);

       

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
