using AutoMapper;
using LMS.Application.Contracts.Persistence;
using LMS.Application.Dtos.Finance;
using MediatR;
using LMS.Application.Features.Queries.Requests_Handlers.Finance.PaymentTuition.Requests;

namespace LMS.Application.Features.Queries.Requests_Handlers.Finance.PaymentTuition
{
    public class GetPaymentTuitionListRequestHandler : IRequestHandler<GetPaymentTuitionListRequest, List<PaymentTuitionDto>>
    {
        IMapper _mapper;
        IUnitOfWork _unitofwork;

        public GetPaymentTuitionListRequestHandler(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<List<PaymentTuitionDto>> Handle(GetPaymentTuitionListRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var PaymentTuitionList = await _unitofwork.PaymentTuitionRepository.GetAllAsync();
                return _mapper.Map<List<PaymentTuitionDto>>(PaymentTuitionList);
            }
            catch
            {
                throw;
            }
        }
    }
}
