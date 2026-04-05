
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
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
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
                GetRuntimeLogsResponseLevel.Error => "error",
                GetRuntimeLogsResponseLevel.Info => "info",
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
                "error" => GetRuntimeLogsResponseLevel.Error,
                "info" => GetRuntimeLogsResponseLevel.Info,
                "warning" => GetRuntimeLogsResponseLevel.Warning,
                _ => null,
            };
        }
    }
}