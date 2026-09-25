
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetVercelCiInvocationLogsLevelItem
    {
        /// <summary>
        ///
        /// </summary>
        Command,
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
        SystemError,
        /// <summary>
        ///
        /// </summary>
        Trace,
        /// <summary>
        ///
        /// </summary>
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVercelCiInvocationLogsLevelItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVercelCiInvocationLogsLevelItem value)
        {
            return value switch
            {
                GetVercelCiInvocationLogsLevelItem.Command => "command",
                GetVercelCiInvocationLogsLevelItem.Debug => "debug",
                GetVercelCiInvocationLogsLevelItem.Error => "error",
                GetVercelCiInvocationLogsLevelItem.Fatal => "fatal",
                GetVercelCiInvocationLogsLevelItem.Info => "info",
                GetVercelCiInvocationLogsLevelItem.SystemError => "systemError",
                GetVercelCiInvocationLogsLevelItem.Trace => "trace",
                GetVercelCiInvocationLogsLevelItem.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVercelCiInvocationLogsLevelItem? ToEnum(string value)
        {
            return value switch
            {
                "command" => GetVercelCiInvocationLogsLevelItem.Command,
                "debug" => GetVercelCiInvocationLogsLevelItem.Debug,
                "error" => GetVercelCiInvocationLogsLevelItem.Error,
                "fatal" => GetVercelCiInvocationLogsLevelItem.Fatal,
                "info" => GetVercelCiInvocationLogsLevelItem.Info,
                "systemError" => GetVercelCiInvocationLogsLevelItem.SystemError,
                "trace" => GetVercelCiInvocationLogsLevelItem.Trace,
                "warn" => GetVercelCiInvocationLogsLevelItem.Warn,
                _ => null,
            };
        }
    }
}