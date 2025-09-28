using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Identity;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Identity.PhoneNumber.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.PhoneNumber
{
    public class GetPhoneNumberByIdRequestHandler : IRequestHandler<GetPhoneNumberByIdRequest, PhoneNumberDto>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetPhoneNumberByIdRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<PhoneNumberDto> Handle(GetPhoneNumberByIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var PhoneNumber = await _unitofwork.PhoneNumberRepository.GetByIdAsync(request.Id);
                return _mapper.Map<PhoneNumberDto>(PhoneNumber);
            }
            catch
            {
                throw;
            }
        }
    }
}
