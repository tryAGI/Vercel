
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetVercelCiTaskRunLogsLevelItem
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
    public static class GetVercelCiTaskRunLogsLevelItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVercelCiTaskRunLogsLevelItem value)
        {
            return value switch
            {
                GetVercelCiTaskRunLogsLevelItem.Command => "command",
                GetVercelCiTaskRunLogsLevelItem.Debug => "debug",
                GetVercelCiTaskRunLogsLevelItem.Error => "error",
                GetVercelCiTaskRunLogsLevelItem.Fatal => "fatal",
                GetVercelCiTaskRunLogsLevelItem.Info => "info",
                GetVercelCiTaskRunLogsLevelItem.SystemError => "systemError",
                GetVercelCiTaskRunLogsLevelItem.Trace => "trace",
                GetVercelCiTaskRunLogsLevelItem.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVercelCiTaskRunLogsLevelItem? ToEnum(string value)
        {
            return value switch
            {
                "command" => GetVercelCiTaskRunLogsLevelItem.Command,
                "debug" => GetVercelCiTaskRunLogsLevelItem.Debug,
                "error" => GetVercelCiTaskRunLogsLevelItem.Error,
                "fatal" => GetVercelCiTaskRunLogsLevelItem.Fatal,
                "info" => GetVercelCiTaskRunLogsLevelItem.Info,
                "systemError" => GetVercelCiTaskRunLogsLevelItem.SystemError,
                "trace" => GetVercelCiTaskRunLogsLevelItem.Trace,
                "warn" => GetVercelCiTaskRunLogsLevelItem.Warn,
                _ => null,
            };
        }
    }
}