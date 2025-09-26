using AutoMapper;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity.Validations;
using LMS.Application.Features.Commands.Handlers.Identity.Student.Requests;
using MediatR;

namespace LMS.Application.Features.Commands.Handlers.Identity.Student
{
    public class CreateStudentRequestHandler : IRequestHandler<CreateStudentRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        StudentValidator _validator;
        public CreateStudentRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, StudentValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        public async Task<BaseCommandResponse> Handle(CreateStudentRequest request, CancellationToken cancellationToken)
        {

            var validationResult = await _validator.ValidateAsync(request.StudentDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return new BaseCommandResponse
                {
                    Status = ResponseStatusCodes.ValidationError,
                    Message = ResponseMessageText.FAILD_SAVING,
                    Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList()
                };
            }
            try
            {
                var Student = _mapper.Map<LMS.ApplicationCore.Entities.Identity.Student>(request.StudentDto);
                await _unitOfWork.StudentRepository.AddAsync(Student);
                return new BaseCommandResponse
                {
                    Status = ResponseStatusCodes.Success,
                    Message = ResponseMessageText.SUCCESSFUL_SAVING,
                };

            }
            catch (Exception ex)
            {
                return new BaseCommandResponse
                {
                    Status = ResponseStatusCodes.Faild,
                    Message = ResponseMessageText.FAILD_SAVING,
                    Errors = new List<string> { ex.Message }
                };
            }
        }
    }
}
