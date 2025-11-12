using clean_architecture_demo_v1.Application.Interfaces;
using clean_architecture_demo_v1.Core.Entities;
using MediatR;

namespace clean_architecture_demo_v1.Application.Commands
{
    public record UpdateEmployeeCommand(Guid EmployeeId, EmployeeEntity Employee)
        : IRequest<EmployeeEntity>;
    public class UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.UpdateEmployeeAsync(request.EmployeeId, request.Employee);
        }
    }
}
