using AutoMapper;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education.Validations;
using LMS.Application.Features.Commands.Requests_Handlers.Education.Level.Requests;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Education.Level
{
    public class CreateLevelRequestHandler : IRequestHandler<CreateLevelRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        LevelValidator _validator;
        public CreateLevelRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, LevelValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        public async Task<BaseCommandResponse> Handle(CreateLevelRequest request, CancellationToken cancellationToken)
        {

            var validationResult = await _validator.ValidateAsync(request.LevelDto, cancellationToken);

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
                var level = _mapper.Map<LMS.ApplicationCore.Entities.Education.Level>(request.LevelDto);
                await _unitOfWork.LevelRepository.AddAsync(level);
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
