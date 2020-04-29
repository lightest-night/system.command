using System.Reflection;
using LightestNight.System.ServiceResolution;
using Microsoft.Extensions.DependencyInjection;

namespace LightestNight.System.Command
{
    public static class ExtendsServiceCollection
    {
        public static IServiceCollection AddCommandValidators(IServiceCollection services, params Assembly[] validatorAssemblies)
        {
            AssemblyScanning.RegisterServices(services, validatorAssemblies, new[]
            {
                new ConcreteRegistration
                {
                    InterfaceType = typeof(ICommandValidator<>),
                    AddIfAlreadyExists = true
                }
            });

            return services;
        }
    }
}