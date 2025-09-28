using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Identity;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Identity.PhoneNumber.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Identity.PhoneNumber{
    public class GetPhoneNumberListRequestHandler : IRequestHandler<GetPhoneNumberListRequest, List<PhoneNumberDto>>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetPhoneNumberListRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<List<PhoneNumberDto>> Handle(GetPhoneNumberListRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var PhoneNumberList = await _unitofwork.PhoneNumberRepository.GetAllAsync();
                return _mapper.Map<List<PhoneNumberDto>>(PhoneNumberList);
            }
            catch
            {
                throw;
            }
        }
    }
}
