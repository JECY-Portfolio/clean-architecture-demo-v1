using MediatR;
using Microsoft.Extensions.Logging;

namespace clean_architecture_demo_v1.Application.Events
{
    public class SendEmailEventHandler(ILogger<SendEmailEventHandler> logger)
        : INotificationHandler<UserCreatedEvent>
    {
        public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("User created: Send mail start for {UserId}", notification.UserId);

            await Task.Delay(2000, cancellationToken);

            logger.LogInformation("User created: Send mail done for {UserId}", notification.UserId);
        }
    }
}
