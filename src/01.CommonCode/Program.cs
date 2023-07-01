namespace Exercise.CommonCode;

public class Program
{
    public static void Main()
    {
        #region Register new Services (Singleton, Scoped, Transient) using Custom Attribute
        //using var host = Host.CreateDefaultBuilder()
        //    .ConfigureServices(services =>
        //    {
        //        services.AutomatedServiceCollectionRegistration();
        //    })
        //    .Build();

        //Console.WriteLine($"\n=== {nameof(AutomatedServiceCollection.ShowAndTestRegisteredServices)} ===\n");
        //AutomatedServiceCollection.ShowAndTestRegisteredServices(host.Services);
        //Console.WriteLine($"\n=== {nameof(AutomatedServiceCollection.ShowAndTestRegisteredServices)} ===\n");

        //host.Run();
        #endregion

        #region Parallelism
        //Parallelism_01.Run();
        #endregion

        #region Reflection
        //IConfiguration configuration = new ConfigurationBuilder()
        //    .AddJsonFile($"appsettings.json")
        //    .Build();

        //var services = new ServiceCollection();
        //services.AddSingleton(configuration);

        ////var config = serviceProvider.GetRequiredService<IConfiguration>();
        ////Console.WriteLine($"SomeKey: {config["SomeKey"]}");

        //ApplyOrderService.GlobalSettings.Scan(services, Assembly.GetExecutingAssembly());

        //var applyOrderModels = ApplyOrderService.GlobalSettings.GetApplyOrderModelsByType<DestinationClass2, SourceClass>();

        //foreach (var applyOrderModel in applyOrderModels)
        //{
        //    Console.WriteLine($"{applyOrderModel.PropertyInfo}, {applyOrderModel.Expression}");
        //}
        #endregion

        #region Nondestructive mutation
        //var firstWindow = new Window { Size = 10, Color = "Red" };
        //Console.WriteLine(firstWindow); // Window { Size = 10, Color = Red }

        //var secondWindow = firstWindow with { Color = "Blue" };
        //Console.WriteLine(secondWindow); // Window { Size = 10, Color = Blue } 
        #endregion

        #region Benchmarks
        //BenchmarkRunner.Run<LoopsBenchmark>();
        #endregion
    }
}