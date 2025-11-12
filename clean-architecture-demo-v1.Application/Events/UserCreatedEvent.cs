using MediatR;

namespace clean_architecture_demo_v1.Application.Events;

public record UserCreatedEvent(Guid UserId) : INotification;

