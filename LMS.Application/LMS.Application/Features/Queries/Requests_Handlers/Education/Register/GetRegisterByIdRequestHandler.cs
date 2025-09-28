using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Education;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Education.Register.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Education.Register
{
    public class GetRegisterByIdRequestHandler : IRequestHandler<GetRegisterByIdRequest, RegisterDto>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetRegisterByIdRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<RegisterDto> Handle(GetRegisterByIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var Register = await _unitofwork.RegisterRepository.GetByIdAsync(request.Id);
                return _mapper.Map<RegisterDto>(Register);
            }
            catch
            {
                throw;
            }
        }
    }
}
