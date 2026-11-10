
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bbdd9b0474e1d24Type
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
    public static class AutoSDKShared6bbdd9b0474e1d24TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bbdd9b0474e1d24Type value)
        {
            return value switch
            {
                AutoSDKShared6bbdd9b0474e1d24Type.Cron => "cron",
                AutoSDKShared6bbdd9b0474e1d24Type.Job => "job",
                AutoSDKShared6bbdd9b0474e1d24Type.Web => "web",
                AutoSDKShared6bbdd9b0474e1d24Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bbdd9b0474e1d24Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared6bbdd9b0474e1d24Type.Cron,
                "job" => AutoSDKShared6bbdd9b0474e1d24Type.Job,
                "web" => AutoSDKShared6bbdd9b0474e1d24Type.Web,
                "worker" => AutoSDKShared6bbdd9b0474e1d24Type.Worker,
                _ => null,
            };
        }
    }
}