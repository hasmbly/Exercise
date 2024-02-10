using Exercise.CommonCode.Resources.Branches.Constants;
using Microsoft.Extensions.Configuration;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Exercise.CommonCode;

public class Program
{
    public static void Main()
    {
        //var configuration = new ConfigurationBuilder()
        //    .AddJsonFile($"appsettings.json")
        //    .Build();

        //var currentCulture = configuration["CurrentCulture"];

        //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(currentCulture!);

        //Console.WriteLine($"{nameof(Thread.CurrentThread.CurrentUICulture)}: {Thread.CurrentThread.CurrentUICulture}");
        //Console.WriteLine($"{nameof(DisplayTextFor.Branch)}: {DisplayTextFor.Branch}");
        //Console.WriteLine($"{nameof(Resources.Materials.Constants.DisplayTextFor.Material)}: {Resources.Materials.Constants.DisplayTextFor.Material}");

        //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");

        //Console.WriteLine($"\n{nameof(Thread.CurrentThread.CurrentUICulture)}: {Thread.CurrentThread.CurrentUICulture}");
        //Console.WriteLine($"{nameof(DisplayTextFor.Branch)}: {DisplayTextFor.Branch}");
        //Console.WriteLine($"{nameof(Resources.Materials.Constants.DisplayTextFor.Material)}: {Resources.Materials.Constants.DisplayTextFor.Material}");

        //var birthDateValue = "19910610";

        //var formattedCellBirthDateValue = Regex.Replace(birthDateValue, "[^.0-9]", string.Empty);

        //if (formattedCellBirthDateValue.Length < 8)
        //{
        //    Console.WriteLine($"formattedCellBirthDateValue: {formattedCellBirthDateValue} is Invalid");
        //}

        //var year = formattedCellBirthDateValue[0..4];
        //var month = formattedCellBirthDateValue[4..6];
        //var day = formattedCellBirthDateValue[6..8];

        //var dateTimeOffSetString = $"{year}-{month}-{day}";

        //if (DateTimeOffset.TryParse(dateTimeOffSetString, out var dateTimeOffSet))
        //{
        //    Console.WriteLine($"formattedCellBirthDateValue: {dateTimeOffSetString} is Valid.");
        //}
        //else
        //{
        //    Console.WriteLine($"formattedCellBirthDateValue: {dateTimeOffSetString} is Invalid");
        //}
    }

    public static void Exercise()
    {
        #region Metadata
        //var metadatas = new List<Metadata>
        //{
        //    new Metadata { Key = "Decimal", Value = 1234.56m },
        //    new Metadata { Key = "String", Value = "Hello World" },
        //    new Metadata { Key = "Int", Value = 10 },
        //};

        //metadatas.ForEach(x => Console.WriteLine(x));
        #endregion

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

        //Helper.Run(() =>
        //{
        //    Console.WriteLine("Hey this is Task");
        //});
    }
}

public class Request
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
}

public class Metadata
{
    public string Key { get; set; } = default!;
    public object Value { get; set; } = default!;

    public override string ToString()
    {
        return $"Key: {Key}, Value: {Value} ({Value.GetType()})";
    }
}