using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Education;
using MediatR;
using LMS.Application.Dtos.Common;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Features.Commands.Handlers.Education.TermCourseType.Requests;

namespace LMS.Application.Features.Commands.Handlers.Education.TermCourseType
{
    public class DeleteTermCourseTypeRequestHandler : IRequestHandler<DeleteTermCourseTypeRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public DeleteTermCourseTypeRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(DeleteTermCourseTypeRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var TermCourseType = await _unitOfWork.TermCourseTypeRepository.GetByIdAsync(request.Id);
                if (TermCourseType == null)
                {
                    return new BaseCommandResponse()
                    {
                        Status = ResponseStatusCodes.NotFound,
                        Message = ResponseMessageText.RECORD_NOT_FOUND,
                    };
                }
                var res = await _unitOfWork.TermCourseTypeRepository.TrashAsync(TermCourseType);
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
