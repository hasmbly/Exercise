using BenchmarkDotNet.Running;
using Exercise.CommonCode.Benchmarks.EFCore;
using Hangfire.SqlServer;
using Hangfire;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using Formatting = Newtonsoft.Json.Formatting;

namespace Exercise.CommonCode
{
    public static class Helper
    {
        public static void ToConsoleTaskDetails(this Task task)
        {
            Console.WriteLine($"[Task: {task.Id}] [TaskStatus: {task.Status}] [IsCompleted: {task.IsCompleted}] [IsCompletedSuccessfully: {task.IsCompletedSuccessfully}]");
        }

        public static decimal RoundTwoDigitComma(this decimal money)
        {
            return Math.Round(money, 2);
        }

        public static string ToPrettyJson<TRequest>(this TRequest request)
        {
            return JToken.Parse(JsonConvert.SerializeObject(request)).ToString(Formatting.Indented);
        }

        public static string ToCurrency0DisplayText(this decimal money) => $"{money:C0}";

        public static string ToCurrency2DisplayText(this decimal money) => $"{money:C2}";

        public static decimal ToTwoDecimalPlaces(this object value) => decimal.Parse(string.Format("{0:0.##}", value, CultureInfo.InvariantCulture));



        public static Task? Job(string? jobId = null)
        {
            jobId ??= NewBase64Guid();

            var task = Task.Run(async () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"[Id: {jobId}] [{nameof(Job)}] Count: {i}");

                    await Task.Delay(1000);

                    if (i == 8)
                    {
                        throw new Exception("Ups there's something wrong dude");
                    }
                }
            });

            return task;
        }

        public static async Task JobAsync(string? jobId = null)
        {
            jobId ??= NewBase64Guid();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"[Id: {jobId}] [{nameof(JobAsync)}]  Count: {i}");

                await Task.Delay(1000);
            }
        }

        public static async Task CheckJobStatus(Task task)
        {
            while (true)
            {
                // IsCompleted: set true if 'task' was finished 'finish or break by exception'
                // IsCompletedSuccessfully: set true if 'task' was completely finished without 'error/exception'
                task.ToConsoleTaskDetails();

                if (task.IsCompleted)
                {
                    task.ToConsoleTaskDetails();

                    return;
                }

                await Task.Delay(1000);
            }
        }

        /// <summary>
        /// Check if Directory was exist, if not exist then create new directory
        /// </summary>
        /// <param name="directoryPath"></param>
        public static void CheckAndCreateDirectory(string directoryPath = @"C://AutomatedTask/Accurate/ReportDownloader")
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            else
            {
                Console.WriteLine("Directory Already Exist");
            }
        }

        /// <summary>
        /// Check if All Files has been downloaded in "DownloadFolderPath"
        /// </summary>
        /// <param name="downloadFolderPath"></param>
        /// <param name="extensions"></param>
        /// <returns></returns>
        public static bool IsAllFilesHasBeenDownloaded(string downloadFolderPath = @"C://AutomatedTask/Accurate/ReportDownloader", string[]? extensions = null)
        {
            extensions ??= new string[] { ".crdownload", ".tmp" };

            var directoryInfo = new DirectoryInfo(downloadFolderPath);

            var directoryFiles = directoryInfo.EnumerateFiles();

            var stats = !directoryFiles.Where(x => extensions.Contains(x.Extension)).Any();

            return stats;
        }

        public static void RunBenchMarksForEFCore()
        {
            BenchmarkRunner.Run<PopulateFirst_VS_AlwaysPopulateInLoop_EFCoreBenchamarks>();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void StartHangfire()
        {
            GlobalConfiguration.Configuration
            .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
            .UseColouredConsoleLogProvider()
            .UseSimpleAssemblyNameTypeSerializer()
            .UseRecommendedSerializerSettings()
            .UseSqlServerStorage("Server=(localdb)\\mssqllocaldb;Database=AdventureWorks2019;Trusted_Connection=True;", new SqlServerStorageOptions
            {
                CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                QueuePollInterval = TimeSpan.Zero,
                UseRecommendedIsolationLevel = true
            });

            //BackgroundJob.Enqueue(() => BackgroundJobs.HangfireJobs.Hangfire_Failed_Job(0));
            //BackgroundJob.Enqueue(() => BackgroundJobs.HangfireJobs.Hangfire_Failed_Job(1));

            BackgroundJob.Enqueue(() => BackgroundJobs.HangfireJobs.SalesInvoiceJob(1));
            BackgroundJob.Enqueue(() => BackgroundJobs.HangfireJobs.SalesInvoiceJob(2));
            BackgroundJob.Enqueue(() => BackgroundJobs.HangfireJobs.SalesReturnJob(3));
            BackgroundJob.Enqueue(() => BackgroundJobs.HangfireJobs.SalesReturnJob(4));

            using var server = new BackgroundJobServer();
            Console.ReadLine();
        }

        public static void DoTrim()
        {
            var requestContent = " Hasbi";
            var existingContents = new List<string> { "Hasbi", "Radit" };

            Console.WriteLine($"ContentExist - Contains + Trim: {existingContents.Contains(requestContent.Trim())}");

            Console.WriteLine($"ContentExist - Equal: {existingContents.Where(x => requestContent.Contains(x)).Any()}");
        }

        public static void CompareRequestAndExistingDatas()
        {
            var requestDatas = new List<string> { "Product 01", "Product 02" };
            var existingDatas = new List<string> { "Product 01", "Product 02", "Product 03", "Product 04" };

            Console.WriteLine($"Request Data:");
            requestDatas.ForEach(x => Console.WriteLine($"{x}"));

            Console.WriteLine($"\nExisting Data:");
            existingDatas.ForEach(x => Console.WriteLine($"{x}"));

            var differencesOfDatas = existingDatas
                .Where(existing => requestDatas.All(request => request != existing))
                .ToList();

            foreach (var item in differencesOfDatas)
            {
                existingDatas.Remove(item);
            }

            Console.WriteLine($"\nExisting Data - After Update:");
            existingDatas.ForEach(x => Console.WriteLine($"{x}"));
        }

        public static void CompareExistingAndRequestedDatas()
        {
            var requestDatas = new List<string> { "Product 01", "Product 02", "Product 03", "Product 04" };
            var existingDatas = new List<string> { "Product 01", "Product 02"};

            Console.WriteLine($"Request Data:");
            requestDatas.ForEach(x => Console.WriteLine($"{x}"));

            Console.WriteLine($"\nExisting Data:");
            existingDatas.ForEach(x => Console.WriteLine($"{x}"));

            var differencesOfDatas = requestDatas
                .Where(request => existingDatas.All(existing => existing != request))
                .ToList();

            foreach (var item in differencesOfDatas)
            {
                requestDatas.Remove(item);
            }

            Console.WriteLine($"\nRequest Data - After Update:");
            requestDatas.ForEach(x => Console.WriteLine($"{x}"));
        }

        public static string NewBase64Guid() => Convert.ToBase64String(Guid.NewGuid().ToByteArray());

        public static string GeneratePassword(int length = 16)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        public static void Run(this Action task)
        {
            try
            {
                Console.WriteLine("Loading...");

                task.Invoke();

                Console.WriteLine("Finished...");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}