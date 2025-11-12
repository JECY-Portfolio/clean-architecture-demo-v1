using clean_architecture_demo_v1.Core.Interfaces;
using clean_architecture_demo_v1.Core.Models;
using MediatR;

namespace clean_architecture_demo_v1.Application.Queries
{
    public record GetCoinkdeskDataQuery() : IRequest<CoindeskData>;
    public class GetCoinkdeskDataQueryHandler(IExternalVendorRepository externalVendorRepository)
        : IRequestHandler<GetCoinkdeskDataQuery, CoindeskData>
    {
        public async Task<CoindeskData> Handle(GetCoinkdeskDataQuery request, CancellationToken cancellationToken)
        {
            return await externalVendorRepository.GetData();
        }
    }
}
