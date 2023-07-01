using Hangfire;

namespace Exercise.CommonCode.BackgroundJobs
{
    public static class HangfireJobs
    {
        [DisableConcurrentExecution(timeoutInSeconds: 180)]
        [AutomaticRetry(
            Attempts = 2, 
            DelaysInSeconds = new int[2] { 5, 5 }, 
            LogEvents = true, 
            OnAttemptsExceeded = AttemptsExceededAction.Fail
        )]
        public static void Hangfire_Succeeded_Job(int jobOrder)
        {
            var jobTagName = "[Succeeded]";

            if (jobOrder is 2 or 3)
            {
                jobTagName = "[Failed]";
            }

            Console.WriteLine($"{jobTagName} Job [{jobOrder}],  Started......");

            for (int i = 0; i < 10; i++)
            {
                if (jobOrder is 2 or 3 && i == 9)
                {
                    throw new Exception("Exception Found.");
                }

                Thread.Sleep(2500);

                Console.WriteLine($"{jobTagName} Job [{jobOrder}],  Count: {i}");
            }

            Console.WriteLine($"{jobTagName} Job [{jobOrder}],  Finished......");
        }

        [DisableConcurrentExecution(timeoutInSeconds: 60)]
        [AutomaticRetry(Attempts = 3, DelaysInSeconds = new int[3] { 10, 10, 10 }, LogEvents = true, OnAttemptsExceeded = AttemptsExceededAction.Fail)]
        public static void Hangfire_Failed_Job(int JobOrder)
        {
            Console.WriteLine($"[Failed] Job [{JobOrder}],  Started................................................................");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(2);

                Console.WriteLine($"[Failed] Job [{JobOrder}],  Count: {i}");

                if (i is 9)
                {
                    throw new Exception("Exception Found.");
                }
            }

            Console.WriteLine($"[Failed] Job [{JobOrder}],  Finished................................................................");
        }

        [DisableConcurrentExecution(timeoutInSeconds: 180)]
        [AutomaticRetry(
             Attempts = 2,
             DelaysInSeconds = new int[2] { 5, 5 },
             LogEvents = true,
             OnAttemptsExceeded = AttemptsExceededAction.Fail
         )]
        public static void SalesInvoiceJob(int jobOrder)
        {
            var jobTagName = $"[{nameof(SalesInvoiceJob)}] [Failed]";

            Console.WriteLine($"{jobTagName} Job [{jobOrder}],  Started......");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(2500);

                Console.WriteLine($"{jobTagName} Job [{jobOrder}],  Count: {i}");
            }

            Console.WriteLine($"{jobTagName} Job [{jobOrder}],  Finished......");
        }

        [DisableConcurrentExecution(timeoutInSeconds: 180)]
        [AutomaticRetry(
             Attempts = 2,
             DelaysInSeconds = new int[2] { 5, 5 },
             LogEvents = true,
             OnAttemptsExceeded = AttemptsExceededAction.Fail
         )]
        public static void SalesReturnJob(int jobOrder)
        {
            var jobTagName = $"[{nameof(SalesReturnJob)}] [Failed]";

            Console.WriteLine($"{jobTagName} Job [{jobOrder}],  Started......");

            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    throw new Exception("Exception Found.");
                }

                Thread.Sleep(2500);

                Console.WriteLine($"{jobTagName} Job [{jobOrder}],  Count: {i}");
            }

            Console.WriteLine($"{jobTagName} Job [{jobOrder}],  Finished......");
        }
    }
}