using MassTransit;

namespace MassTransitDemo;

public class PingConsumer : IConsumer<Ping>
{
    private readonly ILogger<PingConsumer> _logger;

    public PingConsumer(ILogger<PingConsumer> logger)
    {
        _logger = logger;
    }


    public Task Consume(ConsumeContext<Ping> context)
    {
        _logger.LogInformation("Received {Button}", context.Message.Button);
        return Task.CompletedTask;
    }

}
