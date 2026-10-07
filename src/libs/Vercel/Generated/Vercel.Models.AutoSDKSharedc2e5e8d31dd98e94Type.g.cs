
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc2e5e8d31dd98e94Type
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
    public static class AutoSDKSharedc2e5e8d31dd98e94TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc2e5e8d31dd98e94Type value)
        {
            return value switch
            {
                AutoSDKSharedc2e5e8d31dd98e94Type.Cron => "cron",
                AutoSDKSharedc2e5e8d31dd98e94Type.Job => "job",
                AutoSDKSharedc2e5e8d31dd98e94Type.Web => "web",
                AutoSDKSharedc2e5e8d31dd98e94Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc2e5e8d31dd98e94Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedc2e5e8d31dd98e94Type.Cron,
                "job" => AutoSDKSharedc2e5e8d31dd98e94Type.Job,
                "web" => AutoSDKSharedc2e5e8d31dd98e94Type.Web,
                "worker" => AutoSDKSharedc2e5e8d31dd98e94Type.Worker,
                _ => null,
            };
        }
    }
}