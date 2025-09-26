using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Education;
using MediatR;
using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Education.Validations;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Features.Commands.Handlers.Education.Register.Requests;

namespace LMS.Application.Features.Commands.Handlers.Education.Register
{
    public class UpdateRegisterRequestHandler : IRequestHandler<UpdateRegisterRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        RegisterValidator _validator;
        public UpdateRegisterRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, RegisterValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        public async Task<BaseCommandResponse> Handle(UpdateRegisterRequest request, CancellationToken cancellationToken)
        {

            var validationResult = await _validator.ValidateAsync(request.RegisterDto, cancellationToken);
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
                var Register = _mapper.Map<LMS.ApplicationCore.Entities.Education.Register>(request.RegisterDto);
                await _unitOfWork.RegisterRepository.UpdateAsync(Register);
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
