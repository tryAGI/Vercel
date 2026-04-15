
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRuntimeLogsResponseLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Debug,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Fatal,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Trace,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRuntimeLogsResponseLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRuntimeLogsResponseLevel value)
        {
            return value switch
            {
                GetRuntimeLogsResponseLevel.Debug => "debug",
                GetRuntimeLogsResponseLevel.Error => "error",
                GetRuntimeLogsResponseLevel.Fatal => "fatal",
                GetRuntimeLogsResponseLevel.Info => "info",
                GetRuntimeLogsResponseLevel.Trace => "trace",
                GetRuntimeLogsResponseLevel.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRuntimeLogsResponseLevel? ToEnum(string value)
        {
            return value switch
            {
                "debug" => GetRuntimeLogsResponseLevel.Debug,
                "error" => GetRuntimeLogsResponseLevel.Error,
                "fatal" => GetRuntimeLogsResponseLevel.Fatal,
                "info" => GetRuntimeLogsResponseLevel.Info,
                "trace" => GetRuntimeLogsResponseLevel.Trace,
                "warning" => GetRuntimeLogsResponseLevel.Warning,
                _ => null,
            };
        }
    }
}