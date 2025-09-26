using AutoMapper;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education.Validations;
using LMS.Application.Features.Commands.Requests_Handlers.Education.TermCourse.Requests;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Education.TermCourse
{
    public class CreateTermCourseRequestHandler : IRequestHandler<CreateTermCourseRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        TermCourseValidator _validator;
        public CreateTermCourseRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, TermCourseValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        public async Task<BaseCommandResponse> Handle(CreateTermCourseRequest request, CancellationToken cancellationToken)
        {

            var validationResult = await _validator.ValidateAsync(request.TermCourseDto, cancellationToken);

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
                var TermCourse = _mapper.Map<LMS.ApplicationCore.Entities.Education.TermCourse>(request.TermCourseDto);
                await _unitOfWork.TermCourseRepository.AddAsync(TermCourse);
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
