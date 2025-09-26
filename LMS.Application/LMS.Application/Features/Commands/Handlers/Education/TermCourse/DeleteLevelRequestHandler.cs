using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Education;
using MediatR;
using LMS.Application.Dtos.Common;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Features.Commands.Handlers.Education.TermCourse.Requests;

namespace LMS.Application.Features.Commands.Handlers.Education.TermCourse
{
    public class DeleteTermCourseRequestHandler : IRequestHandler<DeleteTermCourseRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public DeleteTermCourseRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(DeleteTermCourseRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var TermCourse = await _unitOfWork.TermCourseRepository.GetByIdAsync(request.Id);
                if (TermCourse == null)
                {
                    return new BaseCommandResponse()
                    {
                        Status = ResponseStatusCodes.NotFound,
                        Message = ResponseMessageText.RECORD_NOT_FOUND,
                    };
                }
                var res = await _unitOfWork.TermCourseRepository.TrashAsync(TermCourse);
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
