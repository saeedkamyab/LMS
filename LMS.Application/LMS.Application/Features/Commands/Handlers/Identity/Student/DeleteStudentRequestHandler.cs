using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Features.Commands.Requests.Identity.Student;
using LMS.Application.Dtos.Identity;
using MediatR;
using LMS.Application.Dtos.Common;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;

namespace LMS.Application.Features.Commands.Handlers.Identity.Student
{
    public class DeleteStudentRequestHandler : IRequestHandler<DeleteStudentRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public DeleteStudentRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(DeleteStudentRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var Student = await _unitOfWork.StudentRepository.GetByIdAsync(request.Id);
                if (Student == null)
                {
                    return new BaseCommandResponse()
                    {
                        Status = ResponseStatusCodes.NotFound,
                        Message = ResponseMessageText.RECORD_NOT_FOUND,
                    };
                }
                var res = await _unitOfWork.StudentRepository.TrashAsync(Student);
                return new BaseCommandResponse()
                {
                    Status = ResponseStatusCodes.Success,
                    Message = ResponseMessageText.SUCCESSFUL_DELETING,
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
