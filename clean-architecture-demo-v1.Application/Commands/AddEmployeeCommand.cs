using clean_architecture_demo_v1.Core.Interfaces;
using clean_architecture_demo_v1.Core.Entities;
using MediatR;

namespace clean_architecture_demo_v1.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity Employee) : IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository, IPublisher mediator)
        : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
           return await employeeRepository.AddEmployeeAsync(request.Employee);
        }
    }
}
