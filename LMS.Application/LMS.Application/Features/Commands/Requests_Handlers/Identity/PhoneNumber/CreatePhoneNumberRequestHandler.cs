using AutoMapper;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity.Validations;
using LMS.Application.Features.Commands.Requests_Handlers.Identity.PhoneNumber.Requests;
using MediatR;

namespace LMS.Application.Features.Commands.Requests_Handlers.Identity.PhoneNumber
{
    public class CreatePhoneNumberRequestHandler : IRequestHandler<CreatePhoneNumberRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        PhoneNumberValidator _validator;
        public CreatePhoneNumberRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, PhoneNumberValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        public async Task<BaseCommandResponse> Handle(CreatePhoneNumberRequest request, CancellationToken cancellationToken)
        {

            var validationResult = await _validator.ValidateAsync(request.PhoneNumberDto, cancellationToken);

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
                var PhoneNumber = _mapper.Map<LMS.ApplicationCore.Entities.Identity.PhoneNumber>(request.PhoneNumberDto);
                await _unitOfWork.PhoneNumberRepository.AddAsync(PhoneNumber);
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
