using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Identity;
using MediatR;
using LMS.Application.Dtos.Common;
using LMS.Application.Dtos.Identity.Validations;
using LMS.Application.Constants.Enums;
using LMS.Application.Constants.MessageText;
using LMS.Application.Features.Commands.Requests_Handlers.Identity.Teacher.Requests;

namespace LMS.Application.Features.Commands.Requests_Handlers.Identity.Teacher
{
    public class UpdateTeacherRequestHandler : IRequestHandler<UpdateTeacherRequest, BaseCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        TeacherValidator _validator;
        public UpdateTeacherRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, TeacherValidator validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        public async Task<BaseCommandResponse> Handle(UpdateTeacherRequest request, CancellationToken cancellationToken)
        {

            var validationResult = await _validator.ValidateAsync(request.TeacherDto, cancellationToken);
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
                var Teacher = _mapper.Map<LMS.ApplicationCore.Entities.Identity.Teacher>(request.TeacherDto);
                await _unitOfWork.TeacherRepository.UpdateAsync(Teacher);
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
