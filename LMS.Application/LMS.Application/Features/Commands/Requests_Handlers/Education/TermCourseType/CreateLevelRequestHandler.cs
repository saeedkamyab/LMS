using AutoMapper;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education.Validations;
using LMS.Application.Features.Commands.Requests_Handlers.Education.TermCourseType.Requests;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Education.TermCourseType
{
    public class CreateTermCourseTypeRequestHandler : IRequestHandler<CreateTermCourseTypeRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        TermCourseTypeValidator _validator;
        public CreateTermCourseTypeRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, TermCourseTypeValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        public async Task<BaseCommandResponse> Handle(CreateTermCourseTypeRequest request, CancellationToken cancellationToken)
        {

            var validationResult = await _validator.ValidateAsync(request.TermCourseTypeDto, cancellationToken);

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
                var TermCourseType = _mapper.Map<LMS.ApplicationCore.Entities.Education.TermCourseType>(request.TermCourseTypeDto);
                await _unitOfWork.TermCourseTypeRepository.AddAsync(TermCourseType);
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
