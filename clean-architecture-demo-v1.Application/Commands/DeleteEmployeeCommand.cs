using clean_architecture_demo_v1.Application.Interfaces;
using MediatR;

namespace clean_architecture_demo_v1.Application.Commands
{
    public record DeleteEmployeeCommand(Guid EmployeeId) : IRequest<bool>;
    internal class DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.DeleteEmployeeAsync(request.EmployeeId);
        }
    }
}
