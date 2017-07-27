#if TIZEN
    using Tizen;
#else
    using System;
#endif // TIZEN

namespace NUnit.Runner.Services
{
    public class NUnitLogs
    {
        public static void LogMessage(string message)
        {
#if TIZEN
            Tizen.Log.Debug("NUNIT", $"{message}");
#else
            System.Diagnostics.Debug.WriteLine($"{message}");
#endif // TIZEN
            }
        }
}
