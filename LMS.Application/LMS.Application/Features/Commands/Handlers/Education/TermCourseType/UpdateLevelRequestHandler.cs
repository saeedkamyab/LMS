using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Features.Commands.Requests.Education.TermCourseType;
using LMS.Application.Dtos.Education;
using MediatR;
using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education.Validations;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;

namespace LMS.Application.Features.Commands.Handlers.Education.TermCourseType
{
    public class UpdateTermCourseTypeRequestHandler : IRequestHandler<UpdateTermCourseTypeRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        TermCourseTypeValidator _validator;
        public UpdateTermCourseTypeRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, TermCourseTypeValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        public async Task<BaseCommandResponse> Handle(UpdateTermCourseTypeRequest request, CancellationToken cancellationToken)
        {

            var validationResult = await _validator.ValidateAsync(request.TermCourseTypeDto, cancellationToken);
            if(!validationResult.IsValid)
            {
                return new BaseCommandResponse()
                {
                    Status = ResponseStatusCodes.ValidationError,
                    Message = ResponseMessageText.FAILD_SAVING,
                    Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList()
                };
            }
            try
            {
                var TermCourseType = _mapper.Map<LMS.ApplicationCore.Entities.Education.TermCourseType>(request.TermCourseTypeDto);
                await _unitOfWork.TermCourseTypeRepository.UpdateAsync(TermCourseType);
                return new BaseCommandResponse
                {
                    Status = ResponseStatusCodes.Success,
                    Message = ResponseMessageText.SUCCESSFUL_SAVING,
                };
            }
            catch(Exception ex)
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
