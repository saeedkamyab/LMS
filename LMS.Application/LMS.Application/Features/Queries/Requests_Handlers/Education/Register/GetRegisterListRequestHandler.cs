using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Education;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Education.Register.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Education.Register
{
    public class GetRegisterListRequestHandler : IRequestHandler<GetRegisterListRequest, List<RegisterDto>>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetRegisterListRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<List<RegisterDto>> Handle(GetRegisterListRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var RegisterList = await _unitofwork.RegisterRepository.GetAllAsync();
                return _mapper.Map<List<RegisterDto>>(RegisterList);
            }
            catch
            {
                throw;
            }
        }
    }
}
