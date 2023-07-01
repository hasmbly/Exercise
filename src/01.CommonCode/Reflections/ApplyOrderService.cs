using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Exercise.CommonCode.Reflections;

public class ApplyOrderService
{
    public List<object> ApplyOrderMapperObjects { get; private set; } = new List<object>();

    public static ApplyOrderService GlobalSettings { get; } = new ApplyOrderService();

    public List<ApplyOrderModel> GetApplyOrderModelsByType<TDestination, TSource>()
        where TDestination : class
        where TSource : class
    {
        var instance = GetObjectByDestinationAndSource<TDestination, TSource>(ApplyOrderMapperObjects);

        return (List<ApplyOrderModel>)instance!.GetType().GetProperty(nameof(ApplyOrderFactory<TDestination, TSource>.ApplyOrderModels))!.GetValue(instance)!;
    }

    private object? GetObjectByDestinationAndSource<TDestination, TSource>(List<object> listOfObjects)
        where TDestination : class
        where TSource : class
    {
        var instance = listOfObjects
            .Where(x =>
                x.GetType().BaseType!.GetGenericArguments()[0] == typeof(TDestination) &&
                x.GetType().BaseType!.GetGenericArguments()[1] == typeof(TSource)
            )
            .FirstOrDefault();

        return instance;
    }

    public void Scan(IServiceCollection services, params Assembly[] assemblies)
    {
        var serviceProvider = services.BuildServiceProvider();

        var results = new List<object>();

        var types = assemblies
            .SelectMany(x => x.GetTypes())
            .Where(x =>
                !x.IsInterface &&
                x.BaseType is not null &&
                x.BaseType.GetInterfaces().Contains(typeof(IApplyOrder)))
            .ToArray();

        foreach (var type in types)
        {
            var constructorParameters = new List<object>();

            var classConstructors = type.GetConstructors() ?? throw new Exception("Please add Constructor.");

            if (classConstructors.Length > 1)
            {
                throw new Exception("Only One Constructor Allowed.");
            }

            var classConstructor = classConstructors.FirstOrDefault();

            foreach (var parameter in classConstructors.FirstOrDefault()!.GetParameters())
            {
                var service = serviceProvider.GetService(parameter.ParameterType);

                if (service is not null)
                {
                    constructorParameters.Add(service);
                }
            }

            var instance = Activator.CreateInstance(type, constructorParameters.ToArray());

            if (instance is not null)
            {
                results.Add(instance);
            }
        }

        GlobalSettings.ApplyOrderMapperObjects = results;
    }
}