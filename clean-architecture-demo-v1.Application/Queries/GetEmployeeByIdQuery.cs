using clean_architecture_demo_v1.Core.Interfaces;
using clean_architecture_demo_v1.Core.Entities;
using MediatR;

namespace clean_architecture_demo_v1.Application.Queries
{
    public record GetEmployeeByIdQuery(Guid EmployeeId) : IRequest<EmployeeEntity>;
    public class GetEmployeeByIdQueryHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<GetEmployeeByIdQuery, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployeeByIdAsync(request.EmployeeId);
        }
    }
}
