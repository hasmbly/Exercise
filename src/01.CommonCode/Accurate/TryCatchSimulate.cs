using System.Diagnostics;
using System.Reflection;

namespace Exercise.CommonCode.Accurate
{
    public static class TryCatchSimulate
    {
        public static void Run()
        {
            DoTryCatchSimulate();
        }

        public static void DoTryCatchSimulate()
        {
            try
            {
                try
                {
                    var callThrowSomeExceptions = ThrowSomeExceptions();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception exception)
            {
                var methodName = GetCallForExceptionThisMethod(MethodBase.GetCurrentMethod(), exception);

                Console.WriteLine($"exception from method: {methodName} from Exception: {exception.GetType().FullName}: {exception.ToPrettyJson()}");
            }
        }

        public static string ThrowSomeExceptions()
        {
            try
            {
                throw new InvalidDataException($"Hey This is an exception");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static string? GetCallForExceptionThisMethod(MethodBase? methodBase, Exception e)
        {
            StackTrace trace = new(e);
            StackFrame? previousFrame = null;

            foreach (StackFrame frame in trace.GetFrames())
            {
                if (frame.GetMethod() == methodBase)
                {
                    break;
                }

                previousFrame = frame;
            }

            return previousFrame?.GetMethod()?.Name;
        }
    }
}