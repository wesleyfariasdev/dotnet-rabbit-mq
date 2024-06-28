using MassTransit;
using MassTransit.Logging;
using Microsoft.Extensions.Options;

namespace DotnetRabbitMQ.Extensions
{
    internal static class AppExtensions
    {
        public static void AddRabbitMQService(this IServiceCollection services)
        {
            services.AddMassTransit(busConfigurator =>
            {
                busConfigurator.UsingRabbitMq((ctx, cfg) =>
                 {
                     cfg.Host(new Uri("amqp://172.17.0.2:5672"), host =>
                     {
                         host.Username("guest");
                         host.Password("guest");
                        
                     });

                     cfg.ConfigureEndpoints(ctx);
                 });
            });
        }
    }
}
