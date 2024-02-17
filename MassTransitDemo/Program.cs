using MassTransit;
using MassTransitDemo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMassTransit(x =>
{
    // x.AddConsumer<PingConsumer>();
    x.AddConsumers(typeof(Program).Assembly);
    x.UsingInMemory((context, cfg) =>
    {
        // cfg.Host("localhost");
        cfg.ConfigureEndpoints(context);
    });
});

builder.Services.AddHostedService<PingPublisher>();

var app = builder.Build();

app.Run();
