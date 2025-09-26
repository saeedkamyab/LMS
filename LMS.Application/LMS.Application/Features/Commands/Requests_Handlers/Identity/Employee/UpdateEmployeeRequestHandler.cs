using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Identity;
using MediatR;
using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity.Validations;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Features.Commands.Requests_Handlers.Identity.Employee.Requests;

namespace LMS.Application.Features.Commands.Requests_Handlers.Identity.Employee
{
    public class UpdateEmployeeRequestHandler : IRequestHandler<UpdateEmployeeRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        EmployeeValidator _validator;
        public UpdateEmployeeRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, EmployeeValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        public async Task<BaseCommandResponse> Handle(UpdateEmployeeRequest request, CancellationToken cancellationToken)
        {

            var validationResult = await _validator.ValidateAsync(request.EmployeeDto, cancellationToken);
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
                var Employee = _mapper.Map<LMS.ApplicationCore.Entities.Identity.Employee>(request.EmployeeDto);
                await _unitOfWork.EmployeeRepository.UpdateAsync(Employee);
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
