using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Finance;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Finance.PaymentTuition.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Finance.PaymentTuition
{
    public class GetPaymentTuitionByIdRequestHandler : IRequestHandler<GetPaymentTuitionByIdRequest, PaymentTuitionDto>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetPaymentTuitionByIdRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<PaymentTuitionDto> Handle(GetPaymentTuitionByIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var PaymentTuition = await _unitofwork.PaymentTuitionRepository.GetByIdAsync(request.Id);
                return _mapper.Map<PaymentTuitionDto>(PaymentTuition);
            }
            catch
            {
                throw;
            }
        }
    }
}
