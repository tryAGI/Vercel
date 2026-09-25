
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetVercelCiTaskLogsLevelItem
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
    public static class GetVercelCiTaskLogsLevelItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVercelCiTaskLogsLevelItem value)
        {
            return value switch
            {
                GetVercelCiTaskLogsLevelItem.Command => "command",
                GetVercelCiTaskLogsLevelItem.Debug => "debug",
                GetVercelCiTaskLogsLevelItem.Error => "error",
                GetVercelCiTaskLogsLevelItem.Fatal => "fatal",
                GetVercelCiTaskLogsLevelItem.Info => "info",
                GetVercelCiTaskLogsLevelItem.SystemError => "systemError",
                GetVercelCiTaskLogsLevelItem.Trace => "trace",
                GetVercelCiTaskLogsLevelItem.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVercelCiTaskLogsLevelItem? ToEnum(string value)
        {
            return value switch
            {
                "command" => GetVercelCiTaskLogsLevelItem.Command,
                "debug" => GetVercelCiTaskLogsLevelItem.Debug,
                "error" => GetVercelCiTaskLogsLevelItem.Error,
                "fatal" => GetVercelCiTaskLogsLevelItem.Fatal,
                "info" => GetVercelCiTaskLogsLevelItem.Info,
                "systemError" => GetVercelCiTaskLogsLevelItem.SystemError,
                "trace" => GetVercelCiTaskLogsLevelItem.Trace,
                "warn" => GetVercelCiTaskLogsLevelItem.Warn,
                _ => null,
            };
        }
    }
}