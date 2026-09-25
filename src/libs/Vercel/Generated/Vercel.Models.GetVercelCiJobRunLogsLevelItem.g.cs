
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetVercelCiJobRunLogsLevelItem
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
    public static class GetVercelCiJobRunLogsLevelItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVercelCiJobRunLogsLevelItem value)
        {
            return value switch
            {
                GetVercelCiJobRunLogsLevelItem.Command => "command",
                GetVercelCiJobRunLogsLevelItem.Debug => "debug",
                GetVercelCiJobRunLogsLevelItem.Error => "error",
                GetVercelCiJobRunLogsLevelItem.Fatal => "fatal",
                GetVercelCiJobRunLogsLevelItem.Info => "info",
                GetVercelCiJobRunLogsLevelItem.SystemError => "systemError",
                GetVercelCiJobRunLogsLevelItem.Trace => "trace",
                GetVercelCiJobRunLogsLevelItem.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVercelCiJobRunLogsLevelItem? ToEnum(string value)
        {
            return value switch
            {
                "command" => GetVercelCiJobRunLogsLevelItem.Command,
                "debug" => GetVercelCiJobRunLogsLevelItem.Debug,
                "error" => GetVercelCiJobRunLogsLevelItem.Error,
                "fatal" => GetVercelCiJobRunLogsLevelItem.Fatal,
                "info" => GetVercelCiJobRunLogsLevelItem.Info,
                "systemError" => GetVercelCiJobRunLogsLevelItem.SystemError,
                "trace" => GetVercelCiJobRunLogsLevelItem.Trace,
                "warn" => GetVercelCiJobRunLogsLevelItem.Warn,
                _ => null,
            };
        }
    }
}