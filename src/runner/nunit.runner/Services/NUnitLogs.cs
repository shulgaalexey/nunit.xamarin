#if __TIZEN__
    using Tizen;
#else
    using System;
#endif // __TIZEN__

namespace NUnit.Runner.Services
{
    public class NUnitLogs
    {
        public static void LogMessage(string message)
        {
#if __TIZEN__
            Tizen.Log.Debug("NUNIT", $"{message}");
#else
            System.Diagnostics.Debug.WriteLine($"NUNIT {message}");
#endif // __TIZEN__
            }
        }
}
