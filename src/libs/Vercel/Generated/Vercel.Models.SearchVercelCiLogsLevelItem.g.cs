
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchVercelCiLogsLevelItem
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
    public static class SearchVercelCiLogsLevelItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchVercelCiLogsLevelItem value)
        {
            return value switch
            {
                SearchVercelCiLogsLevelItem.Command => "command",
                SearchVercelCiLogsLevelItem.Debug => "debug",
                SearchVercelCiLogsLevelItem.Error => "error",
                SearchVercelCiLogsLevelItem.Fatal => "fatal",
                SearchVercelCiLogsLevelItem.Info => "info",
                SearchVercelCiLogsLevelItem.SystemError => "systemError",
                SearchVercelCiLogsLevelItem.Trace => "trace",
                SearchVercelCiLogsLevelItem.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchVercelCiLogsLevelItem? ToEnum(string value)
        {
            return value switch
            {
                "command" => SearchVercelCiLogsLevelItem.Command,
                "debug" => SearchVercelCiLogsLevelItem.Debug,
                "error" => SearchVercelCiLogsLevelItem.Error,
                "fatal" => SearchVercelCiLogsLevelItem.Fatal,
                "info" => SearchVercelCiLogsLevelItem.Info,
                "systemError" => SearchVercelCiLogsLevelItem.SystemError,
                "trace" => SearchVercelCiLogsLevelItem.Trace,
                "warn" => SearchVercelCiLogsLevelItem.Warn,
                _ => null,
            };
        }
    }
}