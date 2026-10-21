
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared03f29e765d13306dType
    {
        /// <summary>
        ///
        /// </summary>
        Cron,
        /// <summary>
        ///
        /// </summary>
        Job,
        /// <summary>
        ///
        /// </summary>
        Web,
        /// <summary>
        ///
        /// </summary>
        Worker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared03f29e765d13306dTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared03f29e765d13306dType value)
        {
            return value switch
            {
                AutoSDKShared03f29e765d13306dType.Cron => "cron",
                AutoSDKShared03f29e765d13306dType.Job => "job",
                AutoSDKShared03f29e765d13306dType.Web => "web",
                AutoSDKShared03f29e765d13306dType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared03f29e765d13306dType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared03f29e765d13306dType.Cron,
                "job" => AutoSDKShared03f29e765d13306dType.Job,
                "web" => AutoSDKShared03f29e765d13306dType.Web,
                "worker" => AutoSDKShared03f29e765d13306dType.Worker,
                _ => null,
            };
        }
    }
}