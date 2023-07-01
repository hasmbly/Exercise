using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Exercise.CommonCode.CustomAttributes;

public static class AutomatedServiceCollection
{
    public static IServiceCollection AutomatedServiceCollectionRegistration(this IServiceCollection services)
    {
        var interfaces = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsDefined(typeof(ServiceMembers)));

        foreach (var @interface in interfaces)
        {
            var serviceType = ServiceMembers.GetServiceType(@interface);

            var inheritenceTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(@interface));

            foreach (var inheritenceType in inheritenceTypes)
            {
                Console.WriteLine($"Implementation of {@interface.Name}, ClassName: {inheritenceType.Name}");

                switch (serviceType)
                {
                    case ServiceType.Singleton:
                        services.AddSingleton(@interface, inheritenceType);
                        break;

                    case ServiceType.Scope:
                        services.AddScoped(@interface, inheritenceType);
                        break;

                    case ServiceType.Transient:
                        services.AddTransient(@interface, inheritenceType);
                        break;

                    default:
                        break;
                }
            }
        }

        return services;
    }

    public static void ShowAndTestRegisteredServices(IServiceProvider hostProvider)
    {
        using IServiceScope serviceScope = hostProvider.CreateScope();
        var provider = serviceScope.ServiceProvider;

        var myRestClientServices = provider.GetServices<IMyRestClient>();

        foreach (var service in myRestClientServices)
        {
            service.GetAccessToken();
        }

        var informationInMemorytServices = provider.GetServices<IInformationInMemory>();

        foreach (var service in informationInMemorytServices)
        {
            Console.WriteLine($"\nProperty.{nameof(service.Username)}: {service.Username}, from Class: {service.GetType().Name}");
        }
    }
}
